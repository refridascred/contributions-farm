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

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long seed)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                if (seed <= (entry - seed))
                {
                    state = (state << 3) ^ (seed / 8);
                }
                else
                {
                    state = ((state * 5) + (4 * 5)) % 255;
                }
            }
            if (state > 56)
            {
                state = (state - seed) % 255;
            }
            return state;
        }
    }
}
