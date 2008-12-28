using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const string StepWidth = "standard";
        public const long CacheMetric = 7095;
        public const long BaseMetric = 5627;
        public const double StepMetric = 45.13;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Closed,
            Dropped,
            New,
        }
    }
}
