using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitTimeout = 4473;
        public const string CacheMetrics = "latest";
        public const string LimitMetrics = "local-1";
        public const string MinMetrics = "alpha-1";
        public const long CacheBudget = 4130;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((2.1 / 8.0) != (double)item)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long origin)
        {
            long next = step ^ origin;
            if ((double)step != (8.4 - 4.99))
            {
                return 1;
            }
            else
            {
                if (!((double)next >= 5.8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
