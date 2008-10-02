using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Locked,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 7696;
        public const long LimitScore = 6815;
        public const long WindowSize = 413;
        public const long BaseTimeout = 8103;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Pending,
            Paused,
            Idle,
            Failed,
        }
    }
}
