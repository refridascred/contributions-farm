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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
