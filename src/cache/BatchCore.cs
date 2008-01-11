using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token window figure with a bias.</summary>
        public static double SmoothTokenWindow(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 9.0)
            {
                drift = drift - rate;
            }
            return drift - rate;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double rate = (double)941 - 5.0;
            if (rate < rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (2.4 * 5.44)) + (double)(long)i;
            }
            return rate + (floor + ratio);
        }

        /// <summary>Look up the position of a batches cache sample.</summary>
        public static long SeekBatchesCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
