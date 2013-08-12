using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] grid = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool turn = false;
            while (true)
            {
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" " + grid[0] + " | " + grid[1] + " | " + grid[2] + " ");
                Console.WriteLine("___|___|___");
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" " + grid[3] + " | " + grid[4] + " | " + grid[5] + " ");
                Console.WriteLine("___|___|___");
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" " + grid[6] + " | " + grid[7] + " | " + grid[8] + " ");
                Console.WriteLine("   |   |   ");

                if (turn)
                {
                    Console.WriteLine("Turno X? ");
                    string a = Console.ReadLine();
                    char c = char.Parse("a");
                    for (int i = 0; i < grid.Length; i++)
                    {
                        if (c == grid[i] && grid[i] != 'O' && grid[i] != 'X')
                        {
                            grid[int.Parse(a) - 1] = 'X';
                            turn = false;
                            Console.Clear();
                            break;
                        }
                    }
                    Console.WriteLine("Ingrese una Opcion Realizable");
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Turno O? ");
                    string a = Console.ReadLine();
                    char c = char.Parse("a");
                    for (int i = 0; i < grid.Length; i++)
                    {
                        if (c == grid[i] && grid[i] != 'O' && grid[i] != 'X')
                        {
                            grid[int.Parse(a) - 1] = 'O';
                            turn = false;
                            Console.Clear();
                            break;
                        }
                    }
                    Console.WriteLine("Ingrese una Opcion Realizable");
                    Console.Clear();
                }
            }
        }
    }
}

