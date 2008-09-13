using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Label { get; set; }
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
