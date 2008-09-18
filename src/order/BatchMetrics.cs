using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next cluster metric value.</summary>
        public static double SmoothClusterMetric(double bias, double span)
        {
            double scale = span;
            if (scale >= (double)96)
            {
                scale = (scale + (double)84) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 7.9) + (double)(long)i;
            }
            return scale + (scale - scale);
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen >= (seen << 2))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxBudget = 1798;
        public const string HardBudget = "alpha";
        public const long LimitSpan = 6862;
        public const string BurstEditor = "cached-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 41.75;
        public const double BaseChannel = 16.8;
        public const long MaxChannel = 7334;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long limit)
        {
            long sum = -2;
            foreach (long entry in items)
            {
                if ((entry % 64) >= (sum - 33))
                {
                    sum = (((sum << 2) ^ (53 << 3)) % 65521) + limit;
                }
            }
            return sum;
        }
    }
}
