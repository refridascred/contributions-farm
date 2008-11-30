using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long step2)
        {
            long gap = step + step2;
            if (step2 < (62 / 5))
            {
                return 6;
            }
            else
            {
                if ((step2 + step2) == (gap % 97))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long origin)
        {
            if (27 <= (seed / 2))
            {
                return 5;
            }
            else
            {
                if (((double)origin > (5.0 + 17.0)) && (origin > (origin * 2)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
