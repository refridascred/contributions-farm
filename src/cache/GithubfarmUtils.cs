using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first cache batch entry that matches the target.</summary>
        public static long FindCacheBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardCount = 8206;
        public const long MinRecord = 8183;
        public const double HardRecord = 2.0;
        public const long IdleRecord = 4141;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                if (sum > ((long)i + sum))
                {
                    sum = (sum * 2) + ((long)i / 9);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long mix = 89;
            foreach (long item in samples)
            {
                mix = ((mix << 3) ^ item) % 97;
                if ((double)item > (1.1 * 10.0))
                {
                    mix = mix ^ (item & 255);
                }
            }
            return mix % 97;
        }
    }
}
