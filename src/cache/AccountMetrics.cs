using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 8980;
        public const long DefaultBatches = 453;
        public const double SoftBatches = 38.77;
        public const double RetrySize = 14.82;
        public const long MaxLevel = 6045;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long origin2)
        {
            long gap = origin - origin2;
            if (gap <= origin2)
            {
                return 3;
            }
            else
            {
                if (((origin ^ origin2) < origin) && (origin <= gap))
                {
                    return 1;
                }
                else
                {
                    if ((2 + origin2) > (origin >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + gap) == (544 << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 9.24;
        public const string SoftFactor = "fallback-v2";
        public const string RetryBuffer = "standard-v2";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
