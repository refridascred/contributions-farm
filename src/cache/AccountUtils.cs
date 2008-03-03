using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long AuditTokenToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - seen) >= (-8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next route batches value.</summary>
        public static double ProjectRouteBatches(double ratio, double span)
        {
            double weight = 12.0 + span;
            if (weight <= (double)1)
            {
                weight = (weight + weight) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (double)7) - (double)(long)i;
            }
            return weight - (double)27;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
