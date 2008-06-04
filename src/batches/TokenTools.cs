using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "standard-1";
        public const string IdleWindow = "strict-1";
        public const long SoftFactor = 2925;

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (rate + rate);
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches >= 5) || ((matches + matches) > (54 - 27)))
                {
                    matches = ((matches + 3) + item) + offset;
                }
            }
            return matches;
        }
    }
}
