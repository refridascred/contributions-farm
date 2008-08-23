using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 81.36;
        public const string MinBudget = "stable-v2";
        public const long CacheSize = 3420;

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long seed2)
        {
            long cur = seed - seed2;
            if ((26 - cur) > seed2)
            {
                return 3;
            }
            else
            {
                if (!((seed - 2) == (cur - 6)))
                {
                    return 2;
                }
                else
                {
                    if ((double)cur < (9.3 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool CheckAlreadyStreamRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
