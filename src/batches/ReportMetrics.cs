using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Queued,
            Retry,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value != (double)26)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks layout readings.</summary>
        public static long TotalChecksLayout(long[] readings)
        {
            long anchor = 70;
            foreach (long entry in readings)
            {
                anchor = ((anchor - anchor) % 97) + entry;
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ 56) % 97;
            }
            return anchor % 1000;
        }
    }
}
