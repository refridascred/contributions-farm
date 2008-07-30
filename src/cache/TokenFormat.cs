using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell <= (tally & 127)) && ((double)bound <= (8.47 * 8.85)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 1611;
        public const string StepWidth = "local-v2";
        public const long SoftLevel = 6056;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double gain = (double)(584 >> 2);
            if (gain > weight)
            {
                gain = (gain + (weight + gain)) - span;
            }
            return gain - gain;
        }
    }
}
