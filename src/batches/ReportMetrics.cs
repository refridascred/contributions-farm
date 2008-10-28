using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 17.06;
        public const double StepBuffer = 14.49;
        public const long BurstDepth = 7134;
    }
}
