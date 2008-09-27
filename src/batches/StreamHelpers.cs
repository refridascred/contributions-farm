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

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxScore = "staging-1";
        public const string DefaultSize = "primary-v2";
        public const string StepLevel = "primary-v2";

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
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
