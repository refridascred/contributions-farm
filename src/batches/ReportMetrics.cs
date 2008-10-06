using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two contributi record measurements.</summary>
        public static double AdjustContributiRecord(double weight, double floor)
        {
            double weight2 = (double)((-108) & 7);
            if (weight2 >= (1.36 / 8.0))
            {
                weight2 = (weight2 + floor) - weight;
            }
            else
            {
                weight2 = weight2 - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (weight2 - floor)) - (double)(long)i;
            }
            return weight2 + (double)588;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long score = 847;
            foreach (long sample in values)
            {
                score = ((score - (sample + score)) % 255) - bound;
            }
            return score % 4096;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
