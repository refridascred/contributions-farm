using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Pending,
            Done,
            Active,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 90.26;
        public const long BurstTimeout = 3986;
        public const long CacheCount = 3119;
        public const long RetryChannel = 8466;
        public const long SoftChannel = 2206;
    }
}
