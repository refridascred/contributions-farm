using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 8769;
        public const long RetrySize = 141;
        public const double SoftFactor = 57.74;
        public const double IdleScore = 31.88;
        public const long IdleRatio = 9416;
    }
}
