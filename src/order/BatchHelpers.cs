using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 1169;
        public const long SoftDepth = 5690;
        public const long BaseTimeout = 4880;
        public const long BaseBudget = 4529;
        public const long BatchInterval = 1937;

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8888;
        public const long MinProfile = 4153;
        public const long MaxWidth = 865;
    }
}
