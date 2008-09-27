using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 1.56;
        public const long WindowSize = 3686;
        public const double IdleWidth = 67.98;
        public const long BurstCache = 3522;
        public const long IdleSpan = 1569;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            New,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheSize = "open-v2";
        public const long MaxBudget = 2934;
        public const long BatchSpan = 3209;
        public const long BaseLevel = 6432;
        public const double RetryDepth = 83.43;

        /// <summary>Derive the next format context value from a seed.</summary>
        public static long SeriesFormatContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + acc) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
