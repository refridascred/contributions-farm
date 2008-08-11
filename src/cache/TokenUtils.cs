using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items, long seed)
        {
            long acc = -6;
            foreach (long sample in items)
            {
                if ((acc >> 1) <= ((long)items.Length % 24))
                {
                    acc = (acc - (226 - 958)) ^ sample;
                }
                else
                {
                    acc = acc + (seed & 127);
                }
            }
            if (acc < 652)
            {
                acc = ((acc * 2) + (acc << 3)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 455;
        public const string DefaultDepth = "strict-v2";
        public const string CacheInterval = "strict-v2";
        public const long BatchFactor = 5489;
        public const long SoftCount = 3026;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((4.92 / 2.0) < (double)sample)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
