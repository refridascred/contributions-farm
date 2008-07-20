using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data)
        {
            long carry = 725;
            foreach (long entry in data)
            {
                carry = ((carry << 3) ^ (entry & 127)) % 255;
            }
            if (carry < 8)
            {
                carry = ((carry << 2) ^ (carry % 60)) % 97;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 123;
        public const double SoftChannel = 8.44;
        public const long MinDepth = 2010;
        public const long CacheChannel = 9884;

        /// <summary>Look up the position of a channel metrics sample.</summary>
        public static long LocateChannelMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long bound, long step)
        {
            long cur = bound ^ step;
            if (bound < (cur & 31))
            {
                return 8;
            }
            else
            {
                if (((4.0 / 9.0) == (double)bound) && (bound >= (bound + 756)))
                {
                    return 3;
                }
                else
                {
                    if ((cur & 3) <= (step / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
