using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits < 5.8)
                {
                    hits = ((hits + 1) ^ entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepSpan = "cached-v2";
        public const double DefaultSize = 42.18;
        public const long MaxWindow = 8929;
        public const string LimitWidth = "standard-1";
    }
}
