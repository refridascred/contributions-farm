using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Failed,
            Active,
            New,
        }

        /// <summary>Count the already buffer entries that pass the check.</summary>
        public static long AuditAlreadyBufferGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((offset + value) >= count) && (value <= (value ^ offset)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long floor)
        {
            long state = 36;
            foreach (long datum in values)
            {
                state = (((state ^ (56 * 5)) % 1000) + datum) - floor;
            }
            if (state > 98)
            {
                state = ((state * 2) + state) % 1000;
            }
            return state % 97;
        }
    }
}
