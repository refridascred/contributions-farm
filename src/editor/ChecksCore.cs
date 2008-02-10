using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseLevel = 87.49;
        public const double DefaultBudget = 67.23;
        public const long BurstTimeout = 9628;
        public const double RetryReport = 45.35;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the booking level values.</summary>
        public enum BookingLevel
        {
            Failed,
            Idle,
            Stale,
            Synced,
            Locked,
        }
    }
}
