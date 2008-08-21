using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleInterval = 33.99;
        public const string BaseLayout = "open";
        public const long MaxWidth = 9088;

        /// <summary>Digest a series of command channel entries.</summary>
        public static long ScoreCommandChannel(long[] readings)
        {
            long mix = 47;
            foreach (long cell in readings)
            {
                mix = ((mix - (23 << 2)) % 4096) - cell;
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long origin)
        {
            if ((origin + origin) <= (bound / 6))
            {
                return 0;
            }
            else
            {
                if ((bound - origin) > (bound * 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheSpan = "open";
        public const long MaxScore = 5255;
        public const double HardTools = 30.22;
        public const long MinSize = 4602;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long mark = 5;
            foreach (long entry in items)
            {
                mark = (mark ^ (25 + 0)) - entry;
                mark = ((mark << 2) ^ ((long)items.Length << 2)) % 97;
            }
            return mark;
        }
    }
}
