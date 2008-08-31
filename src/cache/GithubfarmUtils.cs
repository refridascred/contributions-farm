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

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 6432;
        public const long IdleInterval = 5747;
        public const string BurstLevel = "stable";
        public const double BatchEditor = 61.56;

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
