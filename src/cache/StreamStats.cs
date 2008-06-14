using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (4.55 / 9.0)) + (double)(long)i;
            }
            return ratio2 + (bias + ratio);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long limit)
        {
            long sum = 143;
            foreach (long entry in values)
            {
                if (sum <= limit)
                {
                    sum = ((sum - (limit - sum)) % 65521) + entry;
                }
                if (limit >= (limit - 57))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long step)
        {
            long mark = 7;
            foreach (long entry in data)
            {
                mark = ((mark - (entry / 9)) % 4096) - step;
            }
            return mark;
        }
    }
}
