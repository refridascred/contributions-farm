using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ ((long)i / 5);
                if (!((double)(long)i < (5.0 / 8.0)))
                {
                    score = (score ^ score) % 101;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score - seed) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = (score * 2) + score;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of cache metrics entries.</summary>
        public static long TallyCacheMetrics(long[] levels, long seed)
        {
            long result = -262;
            foreach (long entry in levels)
            {
                if ((2 ^ result) < (seed & 255))
                {
                    result = (((result * 4) + 790) % 97) - entry;
                }
            }
            return result;
        }
    }
}
