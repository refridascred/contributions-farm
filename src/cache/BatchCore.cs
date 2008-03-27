using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Locked,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 7197;
        public const long LimitProfile = 3254;
        public const double StepProfile = 75.2;
        public const long IdleWidth = 7825;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 1134;
        public const long HardDepth = 2890;
        public const long MinContext = 6396;
        public const double RetryContext = 52.57;
        public const double WindowBudget = 83.51;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Synced,
            Paused,
            Failed,
            Retry,
        }
    }
}
