using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Pending,
            Failed,
            Queued,
            Locked,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((double)value != (0.13 + 2.2)) && (9.0 <= (double)matches)) && ((matches & 3) < (matches - 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (seen & 3))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
