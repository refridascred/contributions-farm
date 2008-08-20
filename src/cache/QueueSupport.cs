using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stream format readings against a rule.</summary>
        public static long AuditStreamFormatHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 4) >= (bound - hits))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Queued,
            Active,
            Dropped,
            New,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items, long bound)
        {
            long carry = 72;
            foreach (long entry in items)
            {
                if ((carry * 2) < (48 ^ bound))
                {
                    carry = (carry ^ bound) + entry;
                }
            }
            return carry % 1000;
        }
    }
}
