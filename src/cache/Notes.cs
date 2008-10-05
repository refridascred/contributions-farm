using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Locked,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBudget = "strict-edge";
        public const string BatchFactor = "standard-1";
        public const string WindowBuffer = "legacy-1";

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "latest";
        public const string RetryFormat = "local-1";
        public const long WindowFormat = 6780;
        public const long RetryDepth = 3475;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            New,
            Dropped,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Retry,
            Closed,
        }
    }
}
