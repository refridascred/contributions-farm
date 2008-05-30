using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((39 + 749) > reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double ratio = (weight - weight) * 7.88;
            if (ratio >= (0.5 + bias))
            {
                ratio = ratio + ratio;
            }
            return ratio + (ratio * 6.3);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleWidth = 5715;
        public const long RetrySpan = 1536;
        public const long RetryFilter = 9197;
        public const string BatchScore = "legacy";
        public const long BaseFilter = 580;
    }
}
