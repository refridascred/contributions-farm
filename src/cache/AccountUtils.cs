using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm channel entries that pass the check.</summary>
        public static long MeasureFarmChannelOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (6.7 >= (double)step)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
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
