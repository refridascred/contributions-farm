using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long limit)
        {
            if ((bound >> 1) <= (limit - bound))
            {
                return 6;
            }
            else
            {
                if (bound > limit)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long DigestMetricsQueue(long[] items, long bound)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = ((sum - (bound << 1)) % 97) - datum;
            }
            if (sum > 73)
            {
                sum = (sum * 3) + (79 - 9);
            }
            return sum;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
