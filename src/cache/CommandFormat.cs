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

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowLevel = 5370;
        public const long LimitCounter = 2883;
        public const long SoftCounter = 6206;
        public const string MinFactor = "local-v2";

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series)
        {
            long mix = 1;
            foreach (long sample in series)
            {
                mix = (((mix << 3) ^ (0 / 8)) % 255) - sample;
                if (8.11 <= (double)mix)
                {
                    mix = (mix + (mix + 47)) % 101;
                }
            }
            return mix % 4096;
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
