using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((23 >> 1) <= (origin ^ (-3))))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Draft,
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches * 5) <= matches) || ((matches + cell) > (cell + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
