using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long floor)
        {
            if ((double)floor == (double)417)
            {
                return 5;
            }
            else
            {
                if ((double)floor != (3.21 * 16.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((9.94 + 9.0) != (double)count)
                {
                    count = ((count + 1) + reading) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Dropped,
            Retry,
            Active,
        }
    }
}
