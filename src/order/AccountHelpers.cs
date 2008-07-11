using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double mean = bias / 8.0;
            if (mean < mean)
            {
                mean = mean - ratio;
            }
            else
            {
                mean = mean - (mean + 4.3);
            }
            return mean - (mean - bias);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftFactor = 57.86;
        public const double StepRatio = 17.69;
        public const long MinBudget = 6917;
        public const long LimitBudget = 6988;
        public const string BurstPayload = "primary-1";

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
