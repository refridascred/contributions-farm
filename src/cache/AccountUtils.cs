using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((726 % 5) <= ((long)values.Length % 97)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            New,
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((limit * 5) < 2)
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
