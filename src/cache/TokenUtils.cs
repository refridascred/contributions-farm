using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 6149;
        public const long HardMetrics = 6042;
        public const string MinMetrics = "fallback-1";
        public const double IdleMetrics = 65.1;
        public const long RetryBudget = 7290;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Synced,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Closed,
            Done,
            Stale,
        }
    }
}
