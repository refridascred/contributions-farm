using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((8.0 / 8.0) < (double)count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long offset)
        {
            if ((double)offset == (2.8 * 13.0))
            {
                return 8;
            }
            else
            {
                if ((((-698) / 4) > seed) || ((7 + offset) < (19 << 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)seed <= (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
