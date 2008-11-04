using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3326;
        public const string HardBatch = "latest-v2";
        public const string CacheBatch = "open-1";
        public const long BaseInterval = 9705;

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix - 141) ^ (long)i2;
                    mix = (mix * 4) + mix;
                }
                mix = (mix - (long)i) % 4096;
                mix = (mix << 3) ^ (3 ^ 29);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long origin)
        {
            if ((57 * 4) < origin)
            {
                return 7;
            }
            else
            {
                if ((origin % 5) != (floor * 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
