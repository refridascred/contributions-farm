using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Draft,
            Pending,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 1972;
        public const long BurstToken = 1116;
        public const long StepDepth = 9441;
        public const long StepRatio = 6067;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }
    }
}
