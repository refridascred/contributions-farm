using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepBudget = "stable-edge";
        public const long RetryScore = 8863;
        public const long WindowCommand = 4548;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            if (50 > (floor >> 4))
            {
                return 3;
            }
            else
            {
                if ((target * 4) > floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor << 2) > floor) && ((938 % 7) >= (floor / 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double gain = 5.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + offset) - (double)(long)i) - scale;
            }
            return gain - (double)498;
        }
    }
}
