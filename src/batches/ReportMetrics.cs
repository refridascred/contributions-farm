using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryInterval = "legacy-v2";
        public const double LimitStream = 28.82;
        public const long CacheScore = 2268;
        public const long SoftDepth = 2959;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long origin)
        {
            long span = floor ^ origin;
            if (((span - 726) <= (span << 2)) || ((double)origin <= (3.6 / 7.0)))
            {
                return 4;
            }
            else
            {
                if (((double)span != (2.4 * 2.4)) && ((8.3 / 7.0) == (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (((1.09 + 17.0) > (double)span) && ((origin % 60) <= (floor + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 255) <= hits)
                {
                    hits = ((hits + 2) + entry) + offset;
                }
            }
            return hits;
        }
    }
}
