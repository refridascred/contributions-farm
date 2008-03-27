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

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Pending,
            Queued,
            New,
            Stale,
        }

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
