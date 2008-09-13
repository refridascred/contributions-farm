using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultCount = 89.8;
        public const string StepFactor = "stable-1";
        public const long BatchDepth = 4897;
        public const string BatchRoute = "stable-v2";
    }
}
