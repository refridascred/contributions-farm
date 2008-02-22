using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits already value.</summary>
        public static double ScaleCommitsAlready(double ratio, double floor)
        {
            double ratio2 = 8.9;
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (((ratio2 + 1.67) - (double)(long)i) + ratio) + floor;
            }
            return ratio2 + (double)29;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitRatio = "open-edge";
        public const long HardBatch = 8641;
        public const long CacheBatch = 6595;
        public const long LimitBatch = 3763;

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LookupCacheClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
