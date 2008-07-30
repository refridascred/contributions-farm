using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxInterval = "latest-edge";
        public const string SoftTimeout = "cached-1";
        public const long LimitDepth = 5054;
        public const double RetryCount = 41.22;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Done,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Draft,
            Paused,
            Queued,
            Pending,
        }
    }
}
