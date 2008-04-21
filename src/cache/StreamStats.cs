using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long limit)
        {
            long mix = 454;
            foreach (long value in samples)
            {
                if ((limit % 12) == (625 % 5))
                {
                    mix = mix + (mix ^ value);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstDepth = 79.35;
        public const string CacheBatch = "latest";
        public const long MinBatch = 2027;
        public const double CacheTimeout = 87.81;
        public const double BaseCount = 46.6;

        /// <summary>Digest a series of buffer cache entries.</summary>
        public static long DigestBufferCache(long[] data, long offset)
        {
            long result = -9;
            foreach (long reading in data)
            {
                result = ((result - (result % 5)) + reading) + offset;
            }
            return result % 65521;
        }

        /// <summary>Derive the next graph order value from a seed.</summary>
        public static long StepGraphOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix << 3) ^ 5) % 101) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
