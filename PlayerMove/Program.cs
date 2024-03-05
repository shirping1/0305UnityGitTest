namespace PlayerMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerX = 1;
            int playerY = 1;


            // file 입출력
            int[,] map = { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                           { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1 },
                           { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1 },
                           { 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1 },
                           { 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1 },
                           { 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1 },
                           { 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1 },
                           { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                           { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                           { 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1 },
                           { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1 },
                           { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };

            while (true)
            {
                // input();
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                //int newPlayerX = playerX;
                //int newPlayerY = playerY;

                // Update();
                if (keyInfo.Key == ConsoleKey.W ||
                    keyInfo.Key == ConsoleKey.UpArrow)
                {
                    //newPlayerY--;
                    if (map[playerY - 1, playerX] != 1)
                    {
                        playerY--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.A ||
                    keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    //newPlayerX--;
                    if (map[playerY, playerX - 1] != 1)
                    {
                        playerX--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.S ||
                    keyInfo.Key == ConsoleKey.DownArrow)
                {
                    //newPlayerY++;
                    if (map[playerY + 1, playerX] != 1)
                    {
                        playerY++;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.D ||
                    keyInfo.Key == ConsoleKey.RightArrow)
                {
                    //newPlayerX++;
                    if (map[playerY, playerX + 1] != 1)
                    {
                        playerX++;
                    }
                }

                //// predict
                //if (map[newPlayerY, playerX] == 1)
                //{
                //    newPlayerX = playerX;
                //    newPlayerY = playerY;
                //}

                //playerX = Math.Clamp(playerX, 0, 80); // playerX의 최소값:0, 최대값:80
                //playerY = Math.Clamp(playerY, 0, 20);

                // Render();
                Console.Clear();

                // Render Map
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        if (map[y, x] == 1)
                        {
                            Console.Write('*');
                        }
                        else if (map[y,x] == 2)
                        {
                            Console.Write('G');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }

                // Render Player
                Console.SetCursorPosition(playerX, playerY);
                Console.Write('P');

                // 승리 조건
                if (map[playerY,playerX] == 2)
                {
                    Console.WriteLine("탈출 성공");
                    break;
                }
            }
        }
    }
}
