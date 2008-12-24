using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "primary-1";
        public const string IdleBudget = "cached-edge";
        public const long CacheFactor = 4618;
        public const string MinMetrics = "cached-edge";
        public const long BatchBudget = 1222;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Dropped,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Paused,
            Active,
            Closed,
            Failed,
        }
    }
}
