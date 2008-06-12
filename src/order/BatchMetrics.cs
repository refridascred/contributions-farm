using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                long cur = ((long)i - bound) >> 2;
                total = total + (cur + total);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (scale * 6.2))
            {
                mean = mean - (scale / 4.0);
            }
            return mean + (double)(-45);
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (span * 7.26))
            {
                gain2 = (gain2 - (double)6) - gain;
            }
            return gain2 + (gain2 / 6.0);
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double scale = (ratio + bias) - bias;
            if (scale >= (16.0 + ratio))
            {
                scale = scale + (double)399;
            }
            else
            {
                scale = scale - (scale / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)9) + (double)(long)i;
            }
            return scale - (double)440;
        }
    }
}
