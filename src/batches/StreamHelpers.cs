using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
