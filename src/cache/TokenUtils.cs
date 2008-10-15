using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (floor - 413))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstSize = 1.8;
        public const long IdleWidth = 4354;
        public const long RetryScore = 6817;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double mean = (double)65 - (double)41;
            if (mean <= (scale * 6.3))
            {
                mean = (mean - scale) - offset;
            }
            else
            {
                mean = mean - (8.28 - mean);
            }
            return mean - scale;
        }
    }
}
