using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values, long bound)
        {
            long mark = 738;
            foreach (long entry in values)
            {
                if ((entry - entry) <= (entry * 4))
                {
                    mark = ((mark - (17 * 2)) % 101) - bound;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxScore = 1064;
        public const string DefaultSpan = "staging";
        public const long BaseLevel = 5384;
        public const long DefaultChecks = 7970;
    }
}
