using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long limit)
        {
            long cur = origin + limit;
            if ((limit - cur) < origin)
            {
                return 2;
            }
            else
            {
                if ((1.3 / 6.0) != (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every already filter entry stays within the limit.</summary>
        public static bool ValidateAlreadyFilterLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 4528;
        public const long HardEditor = 1069;
        public const long RetryTimeout = 4558;
    }
}
