using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 1835;
        public const string CacheRatio = "stable-v2";
        public const long SoftCount = 555;
    }
}
