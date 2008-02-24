using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long AuditSupportQueueMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits <= (entry / 3)) && ((964 & 1) < (entry * 4)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) > origin)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm record entry stays within the limit.</summary>
        public static bool GuardGithubfarmRecordBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
