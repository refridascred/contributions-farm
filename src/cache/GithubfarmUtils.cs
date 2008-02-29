using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheInterval = "legacy-edge";
        public const string BaseSpan = "latest-v2";
        public const long BurstSpan = 4273;
        public const long LimitDepth = 9443;
        public const long LimitFactor = 5749;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits < 0.7)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long TallySupportSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
