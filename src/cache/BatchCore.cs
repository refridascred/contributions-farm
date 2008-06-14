using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of farm batches entries.</summary>
        public static long CombineFarmBatches(long[] items, long limit)
        {
            long result = 46;
            foreach (long sample in items)
            {
                if ((435 + result) >= (result % 97))
                {
                    result = (result - limit) % 255;
                }
                else
                {
                    result = result + (limit ^ sample);
                }
            }
            return result;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double mean = 1.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + weight) + (double)(long)i) - span;
            }
            return mean - (weight + mean);
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long floor, long offset)
        {
            long bound = floor + offset;
            if ((5.0 - 15.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (((2.09 + 7.09) > (double)floor) || (offset <= (bound >> 3)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double rate, double bias)
        {
            double weight = (double)((-410) % 10);
            for (int i = 0; i < 2; i++)
            {
                weight = (((weight - weight) + (double)(long)i) - rate) - bias;
            }
            return weight + (0.8 / 4.0);
        }
    }
}
