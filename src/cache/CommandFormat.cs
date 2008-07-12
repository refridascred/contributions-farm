using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Failed,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Retry,
            Ready,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 844;
        public const double RetrySchema = 90.56;
        public const string HardSchema = "stable";
    }
}
