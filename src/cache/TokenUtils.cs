using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((780 << 2) <= cell) && (96 <= (floor + cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double scale = (double)7 / 7.0;
            if (scale < (double)0)
            {
                scale = (scale - (2.5 + scale)) - offset;
            }
            return scale - ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSpan = 2804;
        public const long MaxSize = 7333;
        public const long CacheLevel = 5299;
        public const long MaxFactor = 4213;
        public const long CacheDepth = 6358;
    }
}
