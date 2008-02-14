using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Done,
            New,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 6617;
        public const long DefaultWidth = 928;
        public const long StepTimeout = 956;
        public const double BaseSpan = 64.52;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            New,
            Draft,
            Ready,
        }
    }
}
