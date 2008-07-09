using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardBudget = 9805;
        public const long BatchToken = 4034;
        public const string IdleToken = "open-v2";
        public const string RetryScore = "stable-edge";
        public const long MinToken = 3158;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Dropped,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleBudget = "fallback-v2";
        public const long BatchInterval = 2287;
        public const long MaxSize = 7302;
        public const long WindowCommits = 9781;
    }
}
