using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double bias = (offset / 2.0) + rate;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (double)4;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally >> 4) < (entry & 255))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 4995;
        public const double IdleBuffer = 34.1;
        public const double BaseBuffer = 66.57;
        public const string BurstBuffer = "stable-edge";
        public const long RetryCount = 4459;
    }
}
