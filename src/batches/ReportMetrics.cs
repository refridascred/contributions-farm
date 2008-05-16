using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long AuditChecksBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) != (datum + hits)) || ((datum < (datum + datum)) && ((double)48 == (double)datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the context already entries that pass the check.</summary>
        public static long TallyContextAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item * 3) > (49 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
