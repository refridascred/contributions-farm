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

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 1865;
        public const long BatchFormat = 6770;
        public const string BurstFormat = "stable";
        public const long CacheFormat = 610;
        public const long RetryCount = 4758;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Pending,
            Dropped,
        }
    }
}
