using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double gain = floor;
            if (gain < 20.0)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (1.0 + bias);
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long state = 929;
            foreach (long entry in readings)
            {
                if (entry > (entry ^ state))
                {
                    state = state ^ state;
                }
                if ((double)state > (18.0 + 5.7))
                {
                    continue;
                }
                else
                {
                    long count = state;
                    state = (state * 3) + (count - 31);
                }
                if (entry >= (entry & 127))
                {
                    state = state ^ (0 * 2);
                }
            }
            if (state < 0)
            {
                state = ((state << 2) ^ (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double gain = bias;
            if (gain < scale)
            {
                gain = gain + scale;
            }
            return gain + (bias / 7.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 42.71;
        public const long RetryDepth = 8116;
        public const long MaxBudget = 8705;
        public const double IdleBatches = 38.25;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
