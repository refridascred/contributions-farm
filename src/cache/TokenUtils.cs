using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a metrics context sample.</summary>
        public static long LookupMetricsContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a metric batches reading.</summary>
        public static double ScaleMetricBatches(double bias, double floor)
        {
            double weight = (double)410 * 3.73;
            if (weight > (double)63)
            {
                weight = (weight - (bias + bias)) - floor;
            }
            return weight - (bias / 3.0);
        }
    }
}
