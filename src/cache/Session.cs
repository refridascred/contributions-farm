using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Done,
            Active,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "staging";
        public const double MinCounter = 54.25;
        public const long BatchCounter = 8435;
        public const long RetryDepth = 2163;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Paused,
            Dropped,
            Closed,
            Queued,
        }
    }
}
