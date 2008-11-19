using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Validate queue cluster readings against a bound.</summary>
        public static bool ValidateQueueClusterLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series)
        {
            long score = 123;
            foreach (long sample in series)
            {
                if (!(sample <= (score - sample)))
                {
                    score = score ^ (score * 3);
                }
            }
            return score % 1000;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (3 < (entry % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
