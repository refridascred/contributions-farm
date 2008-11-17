using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long limit, long target)
        {
            long offset = limit - target;
            if ((target ^ offset) != (offset * 3))
            {
                return 3;
            }
            else
            {
                if ((3.0 / 7.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Done,
            Pending,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(75 > (hits - 308)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
