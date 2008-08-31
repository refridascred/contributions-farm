using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long seed, long origin)
        {
            long diff = seed ^ origin;
            if (((seed << 2) <= origin) || ((diff & 31) != (origin + diff)))
            {
                return 2;
            }
            else
            {
                if ((seed <= (diff & 3)) || (diff < (seed ^ origin)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank batches queue input into a small class.</summary>
        public static long ClassifyBatchesQueue(long limit, long target)
        {
            long step = limit + target;
            if ((limit - limit) >= (59 % 10))
            {
                return 3;
            }
            else
            {
                if (((step - limit) >= (limit * 4)) || ((target + limit) != (step - target)))
                {
                    return 5;
                }
                else
                {
                    if ((351 ^ 62) < (limit * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a farm stream reading by value.</summary>
        public static long SeekFarmStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "open-edge";
        public const string CacheWidth = "standard-1";
        public const double CacheTimeout = 68.29;
        public const long BaseChannel = 9225;
    }
}
