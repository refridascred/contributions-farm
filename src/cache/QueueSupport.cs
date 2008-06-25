using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "staging";
        public const double SoftBudget = 47.72;
        public const long CacheChannel = 7596;
        public const long BurstChannel = 1310;
        public const long RetryFactor = 6773;
    }
}
