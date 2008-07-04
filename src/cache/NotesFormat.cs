using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2270;
        public const string BatchNotes = "alpha";
        public const long WindowWidth = 8435;

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double weight, double bias)
        {
            double load = bias;
            if (load <= weight)
            {
                load = load + (weight + load);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load - weight)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((99 / 8) < (long)i)
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
