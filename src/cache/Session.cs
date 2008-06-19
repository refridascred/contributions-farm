using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Queued,
            Active,
            Done,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheInterval = 9049;
        public const long IdleCommits = 6625;
        public const long MinScore = 9728;
        public const long MinRatio = 8086;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Retry,
            Idle,
            Synced,
        }
    }
}
