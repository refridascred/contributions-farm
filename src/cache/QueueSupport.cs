using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Locked,
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowScore = 8080;
        public const string WindowMetric = "staging-1";
        public const string LimitMetric = "primary-edge";
        public const long StepFactor = 7984;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
