using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long floor)
        {
            if ((floor / 4) < (floor % 97))
            {
                return 8;
            }
            else
            {
                if (!((floor * 3) >= (55 & 255)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long seed)
        {
            long lane = step ^ seed;
            if ((step << 3) == (lane % 64))
            {
                return 4;
            }
            else
            {
                if ((step + step) <= (lane - step))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed >= (13.0 - 1.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up githubfarm filter samples.</summary>
        public static long OverlapGithubfarmFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
