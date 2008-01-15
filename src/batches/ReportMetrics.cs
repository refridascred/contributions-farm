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

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
