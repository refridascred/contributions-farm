using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Locate a counter batch reading by value.</summary>
        public static long LookupCounterBatchIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
