using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double gain, double offset)
        {
            double mean = (double)((-258) % 16);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + gain) + (double)(long)i) + offset;
            }
            return mean - (gain + mean);
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry >= tally) || (tally < (9 + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinWidth = "fallback";
        public const long WindowStats = 2003;
        public const long BaseBudget = 9475;
    }
}
