using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 508;
        public const long RetrySize = 5870;
        public const long HardDepth = 9468;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Pending,
            Retry,
        }
    }
}
