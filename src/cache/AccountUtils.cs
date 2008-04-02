using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long target2)
        {
            long offset = target + target2;
            if ((target2 - offset) == (target2 << 1))
            {
                return 5;
            }
            else
            {
                if (((double)target != (1.8 * 9.23)) || ((double)offset != (1.59 + 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((target2 % 97) == (target << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardLevel = "strict";
        public const string WindowSession = "primary-edge";
        public const string BurstRatio = "cached-1";
        public const long CacheSession = 1960;
    }
}
