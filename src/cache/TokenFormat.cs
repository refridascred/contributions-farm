using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 2786;
        public const long WindowEditor = 2650;
        public const double DefaultCount = 25.42;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            New,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Done,
            Stale,
            Draft,
            Closed,
        }
    }
}
