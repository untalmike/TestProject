/*
    Student Grade application
    ********************************************************************
    97 - 100   A+
    93 - 96    A
    90 - 92    A-
    87 - 89    B+
    83 - 86    B
    80 - 82    B-
    77 - 79    C+
    73 - 76    C
    70 - 72    C-
    67 - 69    D+
    63 - 66    D
    60 - 62    D-
    0  - 59    F
*/

using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[5] {90, 86, 87, 98, 100};
int[] andrewScores = new int[5] {92, 89, 81, 96, 90};
int[] emmaScores = new int[5] {90, 85, 87, 98, 68};
int[] loganScores = new int[5] {90, 95, 87, 88, 96};


int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

foreach (string name in studentNames)
{
    if (name == "Sophia")
    {
        int sophiaSum = 0;
        decimal sophiaScore;

        foreach (int score in sophiaScores)
        {
            sophiaSum += score;
        }
        
        sophiaScore = (decimal)sophiaSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    }


}

decimal andrewScore;
decimal emmaScore;
decimal loganScore;

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
