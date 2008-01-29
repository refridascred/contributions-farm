using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 42.97;
        public const double CacheRoute = 87.44;
        public const double CacheSpan = 75.44;
        public const long StepBudget = 3806;
    }
}
