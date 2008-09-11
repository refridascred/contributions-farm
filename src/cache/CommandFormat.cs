using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftRatio = 8000;
        public const long BaseTimeout = 5343;
        public const long StepWidth = 2808;
        public const double BurstMetrics = 44.9;
        public const string HardLevel = "fallback-edge";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (4.9 + 5.65))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 8316;
        public const long CacheProfile = 19;
        public const long RetrySize = 1375;
        public const long BaseProfile = 2865;

        /// <summary>Classify a stream window pair into a bucket.</summary>
        public static long BucketStreamWindow(long origin, long bound)
        {
            if ((origin / 7) != (1 + origin))
            {
                return 6;
            }
            else
            {
                if ((origin / 3) != (93 + origin))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
