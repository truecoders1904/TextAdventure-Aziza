using System;

namespace againagain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7th Dimensional Muerte");


            Console.WriteLine("Imagine when you die, you wake back up in an underground laboratory");
            Console.Clear();

            Console.WriteLine("Open your eyes...");
            Console.ReadLine();
            Console.WriteLine("You have now entered the 7th dimension of what your perceive \nas Life.");

            Console.WriteLine("Everything that has happened to you thus far, from birth up \nup until your last memory, was somewhat of a virtual reality");

            Console.WriteLine("In order to begin your next path");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Begin");
            Console.ReadLine();

            string doorChoice;

            do
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("There are 3 doors in front of you:");
                Console.WriteLine("green door");
                Console.WriteLine("red door");
                Console.WriteLine("purple door");


                Console.WriteLine("Which door will you choose?");
                doorChoice = Console.ReadLine();

                if (doorChoice.ToLower() == "green door")
                {
                    Console.WriteLine("You fall through the door & it locks behind you..");
                    Console.WriteLine();
                    Console.WriteLine("The dimension is filled with 100 cute duck-sized horses & 1 fugly horse sized duck.. ");
                    Console.WriteLine();
                    Console.WriteLine("RUUUUUUNNNNNNN!!!!!");
                }
                else if (doorChoice.ToLower() == "red door")
                {
                    Console.WriteLine("You're shoved through the door & it disappears..");
                    Console.WriteLine();
                    Console.WriteLine("As you gaze around the unfamiliar space where the world around you is enormous");
                    Console.WriteLine();
                    Console.WriteLine("Suddenly feet start appearing from the air & you look \nat yourself to realized that you are now a roach!!");
                    Console.WriteLine();
                    Console.WriteLine("RUUUUUUNNNNNNN!!!!!");
                }
                else if (doorChoice.ToLower() == "purple door")
                {
                    Console.WriteLine("The minute you cross the threshold you are greeted by \nyour ancestors & family member you lost in the previous dimension");
                    Console.WriteLine();
                    Console.WriteLine("This dimension is filled with tailored dream life that \ncan be altered with mere thought...you are free to exist forever");
                }
                else
                {
                    Console.WriteLine("(response not recognized)");
                }
            } while (doorChoice != "purple door");

            Console.WriteLine("The End");
        }
    }
}
