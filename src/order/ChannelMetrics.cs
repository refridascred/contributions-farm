using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items, long target)
        {
            long sum = 49;
            foreach (long entry in items)
            {
                if (((long)items.Length << 2) != (entry + 160))
                {
                    sum = (sum + target) % 255;
                }
            }
            if (sum > (-2))
            {
                sum = (sum ^ (target - target)) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] data, long target)
        {
            long total = 4;
            foreach (long item in data)
            {
                if ((9.0 / 7.0) <= (double)total)
                {
                    total = ((total + (item << 3)) % 65521) + target;
                }
            }
            return total;
        }
    }
}
