using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard-v2";
        public const long BatchToken = 8419;
        public const long SoftBudget = 5494;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream contributi entries.</summary>
        public static long FoldStreamContributi(long[] readings, long floor)
        {
            long sum = -70;
            foreach (long datum in readings)
            {
                if (!((double)sum <= 5.72))
                {
                    sum = (sum - (floor + 9)) ^ datum;
                }
            }
            if (sum < 6)
            {
                sum = sum ^ (53 ^ sum);
            }
            return sum;
        }

        /// <summary>Blend two layout metric measurements.</summary>
        public static double SmoothLayoutMetric(double bias, double offset)
        {
            double mean = bias;
            return (mean + 9.89) + offset;
        }
    }
}
