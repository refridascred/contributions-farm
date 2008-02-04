using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "local";
        public const double IdleSize = 67.58;
        public const long LimitMetrics = 8297;
        public const string WindowBudget = "fallback";

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((tally + cell) <= (tally * 2)) || (tally > 677)) && ((double)tally > (double)cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRatio = 23.34;
        public const string WindowRecord = "standard";
        public const double BaseSize = 6.14;
        public const long MinRecord = 9891;
        public const long MaxRecord = 6945;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Stale,
            Closed,
            Locked,
        }
    }
}
