using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 8824;
        public const string CacheSession = "latest-v2";
        public const double StepWidth = 12.13;

        /// <summary>Match up metric channel samples.</summary>
        public static long CompareMetricChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command schema value against two limits.</summary>
        public static long ClassifyCommandSchema(long origin, long seed)
        {
            long next = origin + seed;
            if ((next >> 3) > (next % 8))
            {
                return 5;
            }
            else
            {
                if (((53 * 5) > (next & 255)) || ((origin & 127) < (seed << 3)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
