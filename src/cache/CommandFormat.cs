using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 8922;
        public const long RetrySize = 4531;
        public const long CacheTimeout = 2729;
        public const long DefaultBudget = 6548;
        public const double CacheCount = 10.27;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Pending,
            Dropped,
        }
    }
}
