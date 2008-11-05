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

        /// <summary>Digest a series of farm record entries.</summary>
        public static long TotalFarmRecord(long[] data, long floor)
        {
            long mark = 74;
            foreach (long item in data)
            {
                if ((mark >> 1) == (floor + mark))
                {
                    mark = ((mark * 3) + (item * 3)) % 1000;
                }
                if (floor <= item)
                {
                    mark = ((mark << 2) ^ (804 + 23)) % 255;
                }
            }
            if (mark < (-39))
            {
                mark = (mark ^ (701 + mark)) % 65521;
            }
            return mark;
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
