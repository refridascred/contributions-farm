using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Closed,
            New,
            Queued,
        }

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long CountCacheQueueOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((18.0 - 14.0) == (double)bound) && (hits <= (cell - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 5262;
        public const long CacheCluster = 7313;
        public const long LimitCluster = 5652;
        public const long BurstCount = 3652;
        public const long RetryDepth = 2772;

        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - matches) > (datum + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinSize = 3.03;
        public const long HardMetrics = 7275;
        public const long BaseMetrics = 4161;
        public const long BatchWidth = 6190;
    }
}
