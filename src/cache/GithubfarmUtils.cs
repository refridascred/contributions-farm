using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long limit, long seed)
        {
            long diff = limit + seed;
            if (((double)seed <= 9.0) && ((diff + diff) != (diff & 3)))
            {
                return 1;
            }
            else
            {
                if ((limit & 15) > seed)
                {
                    return 0;
                }
                else
                {
                    if ((11 - limit) >= 19)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((limit + 301) != (limit + seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowWidth = 17.48;
        public const long MinInterval = 9440;
        public const string BurstSize = "primary-v2";
    }
}
