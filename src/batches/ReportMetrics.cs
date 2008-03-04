using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series)
        {
            long total = 97;
            foreach (long item in series)
            {
                if ((double)total >= 11.0)
                {
                    total = (total - (item - 6)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((14.0 + 17.0) == (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
