using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const double StepBuffer = 79.36;
        public const long WindowBuffer = 8955;
        public const double LimitLevel = 89.03;
        public const double BatchBuffer = 97.28;

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
