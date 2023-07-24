using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Administrator\\Downloads\\Student.txt";


            try
            {

                string[] lines = File.ReadAllLines(filePath);


                foreach (string line in lines)
                {
                    string[] studentData = line.Split(',');
                    string id =studentData[0];
                    string name = studentData[1];
                    int age = int.Parse(studentData[2]);
                    string grade = studentData[3];

                    Console.WriteLine($"Student ID is: {id}, Student Name: {name}, Student Age: {age}, Student Grade: {grade}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}

