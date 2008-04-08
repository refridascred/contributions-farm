using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Pending,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 1232;
        public const long SoftAccount = 7256;
        public const long DefaultWidth = 6064;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "staging-v2";
        public const long DefaultCount = 4558;
        public const double StepInterval = 54.75;
        public const long HardMetrics = 3680;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
