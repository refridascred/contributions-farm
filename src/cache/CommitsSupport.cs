using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample << 1) < 32) && ((7 + 8) < (sample + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 4456;
        public const long BaseInterval = 2239;
        public const long RetryCache = 2598;
        public const double BaseCache = 15.91;
        public const long CacheLevel = 2843;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum ^ count) < ((long)values.Length << 3)) || !((count * 3) > datum))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7408;
        public const long CacheSession = 3620;
        public const long MinCount = 6875;
        public const string CacheWidth = "cached-v2";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
