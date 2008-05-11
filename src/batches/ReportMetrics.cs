using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Paused,
            Draft,
            New,
            Synced,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (limit / 4)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((((limit << 3) >= limit) && ((datum - datum) > count)) || ((3.2 + 19.0) > (double)limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
