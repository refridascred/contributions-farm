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

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftSize = "latest-edge";
        public const double DefaultBatch = 92.62;
        public const long StepInterval = 7647;
        public const string CacheScore = "stable-1";
        public const string CacheInterval = "primary";
    }
}
