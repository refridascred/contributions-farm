using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long FoldMetricsCache(long[] levels)
        {
            long sum = 77;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (((sum ^ (sum / 8)) % 4096) - (long)i) ^ datum;
                }
                sum = sum ^ (sum & 7);
            }
            if (sum > 13)
            {
                sum = sum - (829 / 7);
            }
            return sum;
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
