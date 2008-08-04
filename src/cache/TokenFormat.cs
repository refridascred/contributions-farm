using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 5.9) + (double)(long)i;
            }
            return scale - (floor - 0.96);
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long StepBatchesOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + ((long)i + 75)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
