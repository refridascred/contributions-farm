using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (item >> 5))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 7778;
        public const long CacheMetrics = 8485;
        public const long MaxMetrics = 2395;
        public const double BaseMetrics = 62.79;
        public const long HardSize = 3676;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long seed)
        {
            long edge = limit ^ seed;
            if (((double)limit > 2.3) && ((limit ^ edge) <= (252 + seed)))
            {
                return 2;
            }
            else
            {
                if ((limit < seed) && ((limit + seed) <= (70 << 3)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits <= (4.04 / 8.0))
                {
                    hits = ((hits + 3) + value) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Done,
            Queued,
            Stale,
            Locked,
        }
    }
}
