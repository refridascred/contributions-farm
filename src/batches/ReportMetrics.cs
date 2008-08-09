using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits / 2) < (1 + 8))
                {
                    hits = ((hits + 3) ^ value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value - 0) >= (660 + value)) && ((6 > (target - value)) && ((hits - 741) >= (value % 97))))
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
    }
}
