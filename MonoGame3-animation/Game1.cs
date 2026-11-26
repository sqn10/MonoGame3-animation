using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoGame3_animation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D tribbleGreyTexture;
        Rectangle tribbleGreyRect;
        Vector2 tribbleGreySpeed;

        Texture2D tribbleBrownTexture;
        Rectangle tribbleBrownRect;
        Vector2 tribbleBrownSpeed;

        Texture2D tribbleCreamTexture;
        Rectangle tribbleCreamRect;
        Vector2 tribbleCreamSpeed;

        Texture2D tribbleOrangeTexture;
        Rectangle tribbleOrangeRect;
        Vector2 tribbleOrangeSpeed;

        SoundEffect tribbleCoo;

        Texture2D discoTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            this.Window.Title = "SQN";

            Random generator = new Random();
            int tribbleSize = generator.Next(80, 101);

            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            tribbleGreyRect = new Rectangle(generator.Next(0, 751), generator.Next(0, 451), tribbleSize, tribbleSize);
            tribbleGreySpeed = new Vector2(generator.Next(1, 21), generator.Next(1, 21));

            tribbleBrownRect = new Rectangle(generator.Next(0, 751), generator.Next(0, 551), tribbleSize, tribbleSize);
            tribbleBrownSpeed = new Vector2(generator.Next(1, 21), generator.Next(1, 11));

            tribbleCreamRect = new Rectangle(generator.Next(0, 751), generator.Next(0, 551), tribbleSize, tribbleSize);
            tribbleCreamSpeed = new Vector2(generator.Next(1, 21), generator.Next(1, 11));

            tribbleOrangeRect = new Rectangle(generator.Next(0, 751), generator.Next(0, 551), tribbleSize, tribbleSize);
            tribbleOrangeSpeed = new Vector2(generator.Next(1, 21), generator.Next(1, 11));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");

            tribbleCoo = Content.Load<SoundEffect>("tribble_coo");

            discoTexture = Content.Load<Texture2D>("disco");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            tribbleGreyRect.X += (int)tribbleGreySpeed.X;
            if(tribbleGreyRect.Right > window.Width || tribbleGreyRect.Left < 0)
            {
                tribbleGreySpeed.X *= -1;
                tribbleCoo.Play();
            }

            tribbleGreyRect.Y += (int)tribbleGreySpeed.Y;
            if(tribbleGreyRect.Bottom > window.Height || tribbleGreyRect.Top < 0)
            {
                tribbleGreySpeed.Y *= -1;
                tribbleCoo.Play();
            }

            // // // // // //

            tribbleBrownRect.X += (int)tribbleBrownSpeed.X;
            if (tribbleBrownRect.Right > window.Width || tribbleBrownRect.Left < 0)
            {
                tribbleBrownSpeed.X *= -1;
                tribbleCoo.Play();
            }

            tribbleBrownRect.Y += (int)tribbleBrownSpeed.Y;
            if (tribbleBrownRect.Bottom > window.Height || tribbleBrownRect.Top < 0)
            {
                tribbleBrownSpeed.Y *= -1;
                tribbleCoo.Play();
            }

            // // // // // // 

            tribbleCreamRect.X += (int)tribbleCreamSpeed.X;
            if (tribbleCreamRect.Right > window.Width || tribbleCreamRect.Left < 0)
            {
                tribbleCreamSpeed.X *= -1;
                tribbleCoo.Play();
            }

            tribbleCreamRect.Y += (int)tribbleCreamSpeed.Y;
            if (tribbleCreamRect.Bottom > window.Height || tribbleCreamRect.Top < 0)
            {
                tribbleCreamSpeed.Y *= -1;
                tribbleCoo.Play();
            }

            // // // // // //

            tribbleOrangeRect.X += (int)tribbleOrangeSpeed.X;
            if (tribbleOrangeRect.Right > window.Width || tribbleOrangeRect.Left < 0)
            {
                tribbleOrangeSpeed.X *= -1;
                tribbleCoo.Play();
            }

            tribbleOrangeRect.Y += (int)tribbleOrangeSpeed.Y;
            if (tribbleOrangeRect.Bottom > window.Height || tribbleOrangeRect.Top < 0)
            {
                tribbleOrangeSpeed.Y *= -1;
                tribbleCoo.Play();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(discoTexture, window, Color.White);

            _spriteBatch.Draw(tribbleGreyTexture, tribbleGreyRect, Color.White);
            _spriteBatch.Draw(tribbleBrownTexture, tribbleBrownRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, tribbleCreamRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture, tribbleOrangeRect, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
