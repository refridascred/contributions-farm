using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstWidth = "open";
        public const long LimitBatch = 1611;
        public const long BurstBatch = 9578;
        public const double RetryBatch = 78.17;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "cached-edge";
        public const long MinTimeout = 6567;
        public const long WindowFactor = 9218;
        public const long StepBuffer = 7784;
        public const long StepBudget = 6275;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
