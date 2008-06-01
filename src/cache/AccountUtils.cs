using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Done,
            Pending,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Closed,
            New,
            Dropped,
        }
    }
}
