using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 4300;
        public const long CacheCommand = 6545;
        public const double WindowWidth = 58.21;
        public const string CacheInterval = "strict-edge";

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
