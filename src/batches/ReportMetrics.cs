using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 29.55;
        public const string DefaultContext = "cached";
        public const long IdleContext = 3391;
        public const long WindowDepth = 8363;
        public const string CacheContext = "stable";

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 7933;
        public const long SoftSupport = 4306;
        public const long LimitWidth = 6313;
        public const double MaxSupport = 36.73;
    }
}
