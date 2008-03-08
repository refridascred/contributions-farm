using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "legacy";
        public const long DefaultBudget = 8752;
        public const string CacheSize = "stable-v2";
        public const long CacheBudget = 7099;
        public const long CacheStream = 3230;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Failed,
            Active,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            New,
            Dropped,
        }
    }
}
