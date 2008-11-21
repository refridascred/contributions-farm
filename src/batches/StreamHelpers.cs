using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many schema commits samples are out of range.</summary>
        public static long AuditSchemaCommitsMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count != (double)item)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9876;
        public const long WindowInterval = 5652;
        public const long BatchScore = 6843;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Paused,
            New,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryTimeout = 7670;
        public const double MinScore = 55.55;
        public const double MaxCommits = 27.98;
        public const long BurstCommits = 1326;

        /// <summary>Find the first batches cache entry that matches the target.</summary>
        public static long LookupBatchesCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Ready,
            Closed,
            Retry,
        }
    }
}
