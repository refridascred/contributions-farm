using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "fallback-1";
        public const long BurstBudget = 4517;
        public const long WindowAccount = 4617;
        public const double SoftInterval = 93.54;
        public const long BurstCount = 7571;

        /// <summary>Fold a list of counter already readings.</summary>
        public static long ScoreCounterAlready(long[] readings, long bound)
        {
            long acc = 63;
            foreach (long item in readings)
            {
                acc = ((acc + (26 >> 1)) + item) + bound;
                if ((4 >> 4) == (acc + acc))
                {
                    acc = (acc ^ (812 + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
