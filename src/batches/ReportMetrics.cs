using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 1689;
        public const string StepNotes = "alpha-v2";
        public const long SoftTimeout = 6098;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Done,
            Locked,
            Ready,
        }
    }
}
