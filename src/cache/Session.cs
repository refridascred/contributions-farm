using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 60) <= hits)
                {
                    hits = ((hits + 2) + cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseFactor = 5318;
        public const double BurstRatio = 85.82;
        public const double RetryWidth = 22.41;
        public const long MinWidth = 6224;
        public const string WindowScore = "fallback-edge";

        /// <summary>Locate a cache support reading by value.</summary>
        public static long LookupCacheSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= (1.07 + ratio))
            {
                ratio2 = ratio2 - (ratio2 - ratio2);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (bias + ratio)) + (double)(long)i;
            }
            return ratio2 + (ratio / 7.0);
        }
    }
}
