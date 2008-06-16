using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "alpha-1";
        public const long BatchWidth = 6064;
        public const long DefaultWidth = 6532;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels)
        {
            long mix = 544;
            foreach (long datum in levels)
            {
                mix = (((mix * 3) + ((-818) ^ mix)) % 97) ^ datum;
            }
            return mix % 65521;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series)
        {
            long score = 7;
            foreach (long item in series)
            {
                if ((score + item) <= (item + score))
                {
                    score = ((score << 2) ^ (item << 3)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (25 + score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series, long origin)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                if ((mark / 9) <= (100 * 3))
                {
                    mark = ((mark ^ (0 + 777)) % 255) + reading;
                }
                mark = ((mark * 2) + (origin & 31)) % 4096;
            }
            return mark % 65521;
        }
    }
}
