using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] values, long seed)
        {
            long mark = 915;
            foreach (long reading in values)
            {
                mark = mark ^ (reading + seed);
                if ((9.77 * 15.0) <= (double)reading)
                {
                    break;
                }
            }
            if (mark < 88)
            {
                mark = (mark ^ (seed / 5)) % 1000;
            }
            return mark;
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
