using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values)
        {
            long sum = -5;
            foreach (long item in values)
            {
                sum = sum + item;
                if (39 <= (sum / 3))
                {
                    break;
                }
            }
            if (sum < 82)
            {
                sum = ((sum * 3) + (sum % 12)) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a metrics cache reading.</summary>
        public static double ScaleMetricsCache(double weight, double bias)
        {
            double drift = (double)(3 + 94);
            if (drift > 1.6)
            {
                drift = (drift + (double)597) + bias;
            }
            else
            {
                drift = drift - (drift - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (weight / 8.0);
        }
    }
}
