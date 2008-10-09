using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = state - (state << 2);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = mix ^ (seed + seed);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of order farm entries.</summary>
        public static long TotalOrderFarm(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                if (((entry >> 4) < ((long)values.Length >> 4)) && ((carry >> 4) != (carry * 5)))
                {
                    carry = (carry - (carry + 73)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double bias)
        {
            double mean = (double)(51 << 2);
            if (mean >= mean)
            {
                mean = (mean - bias) - gain;
            }
            return mean + bias;
        }
    }
}
