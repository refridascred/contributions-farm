using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 3904;
        public const long MinOrder = 6622;
        public const long HardFactor = 2795;
        public const double HardCount = 72.98;

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long step)
        {
            long bound = origin - step;
            if (!(origin <= step))
            {
                return 8;
            }
            else
            {
                if (((double)step > (0.52 - 3.17)) && ((step >> 3) > bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long limit)
        {
            long mix = 996;
            foreach (long item in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix ^ (limit << 1)) % 255) + (long)i;
                    mix = mix - (606 & 63);
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix - (limit - item)) % 255) - (long)i2;
                }
                if ((limit >= (mix + limit)) || ((limit % 2) == (83 - item)))
                {
                    mix = (mix << 2) ^ ((long)items.Length / 9);
                }
                else
                {
                    mix = (mix + (mix + mix)) % 255;
                }
                if ((mix + 45) != (limit + (-9)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double gain = (double)(9 << 2);
            if (gain >= bias)
            {
                gain = (gain - (double)1) + bias2;
            }
            else
            {
                gain = gain + (gain / 4.0);
            }
            return gain - (double)(-222);
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double mean = rate * 11.0;
            if (mean <= (mean - 3.0))
            {
                mean = mean + (rate - span);
            }
            return mean - (double)35;
        }
    }
}
