using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long floor, long origin)
        {
            if ((floor & 3) < (6 & 255))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((38 >> 1) != (floor - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 6994;
        public const string BaseMetrics = "fallback-1";
        public const double IdleWidth = 77.51;
        public const string WindowMetrics = "strict";
        public const long DefaultMetrics = 3163;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample > (hits / 6))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "open-1";
        public const double DefaultSpan = 4.84;
        public const double MinSpan = 6.07;
    }
}
