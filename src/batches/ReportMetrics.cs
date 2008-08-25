using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowDepth = 6095;
        public const long CacheProfile = 7032;
        public const string SoftProfile = "standard-1";
        public const double StepCount = 54.91;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
