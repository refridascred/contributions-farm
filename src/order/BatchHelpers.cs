using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next metric command value.</summary>
        public static double SmoothMetricCommand(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (double)237)
            {
                weight2 = weight2 - (double)75;
            }
            else
            {
                weight2 = weight2 + (offset + offset);
            }
            return weight2 + weight;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long target)
        {
            long slot = floor - target;
            if ((double)target >= (2.7 * 6.4))
            {
                return 8;
            }
            else
            {
                if ((slot + 79) > (floor * 3))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
