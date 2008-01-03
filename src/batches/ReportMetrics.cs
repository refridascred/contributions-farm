using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double bias = (9.93 * 7.0) + 0.5;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (gain * 0.4)) + (double)(long)i) + span;
            }
            return bias + (5.13 / 5.0);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
