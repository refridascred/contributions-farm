using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "cached-v2";
        public const long MinChecks = 3193;
        public const string BurstSpan = "stable";
        public const long StepChecks = 797;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values)
        {
            long total = 40;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (datum ^ datum)) % 101;
            }
            return total;
        }
    }
}
