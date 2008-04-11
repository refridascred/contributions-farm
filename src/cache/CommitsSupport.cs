using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 28.33;
        public const string RetryScore = "open-edge";
        public const long WindowFilter = 2524;
        public const long SoftFilter = 8448;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8980;
        public const long CacheRatio = 283;
        public const string BatchChannel = "fallback";
        public const string SoftFactor = "strict";
        public const double MaxChannel = 23.13;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - seed) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "stable-edge";
        public const long WindowTimeout = 3334;
        public const long BurstAlready = 9766;
        public const long IdleSpan = 4452;
        public const double CacheTimeout = 84.75;

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] series)
        {
            long mark = 204;
            foreach (long cell in series)
            {
                if ((4.0 - 4.53) != (double)mark)
                {
                    mark = (((mark << 2) ^ 63) % 4096) + cell;
                }
            }
            return mark;
        }
    }
}
