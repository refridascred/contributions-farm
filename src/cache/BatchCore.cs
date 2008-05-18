using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double bias = offset * 1.0;
            if (bias <= (double)2)
            {
                bias = (bias - bias) - scale;
            }
            else
            {
                bias = bias - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 2.99) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double mean = (0.5 / 9.0) - (double)8;
            if (mean <= mean)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 8.5) + (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long seed2)
        {
            if (!((seed2 << 1) < (seed2 / 5)))
            {
                return 3;
            }
            else
            {
                if (seed2 > (seed + seed))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
