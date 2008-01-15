using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Closed,
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
