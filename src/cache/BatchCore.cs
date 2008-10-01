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

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 16.24;
        public const long BatchRoute = 5950;
        public const long WindowSpan = 5941;
        public const long LimitRoute = 3159;

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
