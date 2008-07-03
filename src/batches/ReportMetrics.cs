using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double load = span;
            return (load + (5.2 / 9.0)) + ratio;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftSize = "latest-edge";
        public const double DefaultBatch = 92.62;
        public const long StepInterval = 7647;
        public const string CacheScore = "stable-1";
        public const string CacheInterval = "primary";
    }
}
