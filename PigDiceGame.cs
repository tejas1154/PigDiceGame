using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class PigDiceGame
    {
        public static int turnScore = 0;
        public static int finalScore = 0;
        static int totalTurns = 1;
        public static void startGame()
        {
            Random random = new Random();

            Console.WriteLine("Welcome to my game");
            Console.WriteLine("Set the target");
            int target = int.Parse(Console.ReadLine());

            while(finalScore < target)
            {
                Console.WriteLine("\nTurn = " + totalTurns);
                char userChoice = 'r';
                turnScore = 0;

                while(userChoice == 'r')
                {
                    Console.WriteLine("Enter 'r' for role or 'h' for hold");
                    userChoice = char.Parse(Console.ReadLine());

                    if (userChoice == 'h') break;

                    int diceScore = random.Next(1, 10);

                    if(diceScore == 1)
                    {
                        Console.WriteLine("Current Dice is = " + diceScore);
                        Console.WriteLine("Oops.. you got 1.. No Score is added");
                        turnScore = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Current Dice is = " + diceScore);
                        turnScore += diceScore;
                    }      
                }

                finalScore += turnScore;

                Console.WriteLine("\nTotal Turn = " + totalTurns);
                Console.WriteLine("Turn Score = " + turnScore);
                Console.WriteLine("Final Score = " + finalScore);

                if(finalScore >= target)
                {
                    Console.WriteLine("\nYou Won!!!!!!!!!!!!!!!!");
                    Console.WriteLine("Total Turns taken = " + totalTurns);
                }
                totalTurns++;
            }
        }
    }
}
