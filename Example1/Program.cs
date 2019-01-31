using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" What is your name?");
            // This variable will gather data from user input

            string Username = Console.ReadLine();
            // Stores user input as sting called "Username"

            Console.WriteLine("Hello " + Username + "!");
            // Displays users input back to screen
            Console.WriteLine("Press any key to exit the program and try again ...");
            Console.ReadKey(true);






        }// End of main

    }// End of class

} // End namespace 
