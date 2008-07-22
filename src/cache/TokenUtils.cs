using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (1.0 * 8.8))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine channel farm values into a single score.</summary>
        public static long TallyChannelFarm(long[] readings, long offset)
        {
            long score = 339;
            foreach (long item in readings)
            {
                if ((item << 3) > item)
                {
                    score = (score << 2) ^ (874 % 7);
                }
                if ((offset * 5) == (item / 8))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
