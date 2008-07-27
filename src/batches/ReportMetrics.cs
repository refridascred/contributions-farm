using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((431 * 4) <= entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 3290;
        public const long HardBudget = 8934;
        public const long BaseSize = 380;
        public const string LimitSize = "legacy-1";

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
