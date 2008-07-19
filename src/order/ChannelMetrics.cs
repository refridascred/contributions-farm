using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long offset)
        {
            if ((offset >> 1) > offset)
            {
                return 4;
            }
            else
            {
                if ((offset * 2) >= 13)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] series, long bound)
        {
            long carry = 386;
            foreach (long value in series)
            {
                if ((double)bound >= (2.55 * 8.0))
                {
                    carry = (carry * 2) + (bound ^ 256);
                }
                carry = (carry - bound) % 255;
                if ((919 + value) > (carry + bound))
                {
                    carry = (carry - value) % 4096;
                }
                else
                {
                    carry = carry ^ (bound & 31);
                }
            }
            if (carry > 505)
            {
                carry = (carry * 3) + (bound + bound);
            }
            return carry;
        }
    }
}
