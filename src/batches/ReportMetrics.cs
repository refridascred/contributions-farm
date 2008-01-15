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

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] values, long target)
        {
            long mark = 59;
            foreach (long datum in values)
            {
                mark = ((mark + (target & 31)) % 255) ^ datum;
            }
            if (mark > 918)
            {
                mark = mark - (mark + target);
            }
            return mark % 4096;
        }
    }
}
