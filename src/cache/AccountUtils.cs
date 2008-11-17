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

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long step)
        {
            if (((step ^ 730) >= (bound ^ bound)) && ((double)step != (19.0 - 3.5)))
            {
                return 7;
            }
            else
            {
                if ((bound + step) >= (bound + 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
