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

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items, long floor)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = total + (cell + 32);
                total = ((total * 4) + (81 + floor)) % 4096;
                if ((double)cell < 0.6)
                {
                    total = total + cell;
                }
                else
                {
                    total = ((total * 4) + floor) % 65521;
                }
            }
            return total;
        }
    }
}
