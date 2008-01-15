using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value != (5.8 - 1.0))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many queue commits samples are out of range.</summary>
        public static long TallyQueueCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((4.26 / 2.0) >= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
