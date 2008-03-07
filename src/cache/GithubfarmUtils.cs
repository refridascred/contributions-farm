using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 3) ^ 327;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of account channel entries.</summary>
        public static long CombineAccountChannel(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = (acc ^ acc) % 4096;
                if (((long)series.Length / 8) < (cell - acc))
                {
                    acc = (acc - (acc * 2)) % 1000;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (acc & 31)) % 4096;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "open-1";
        public const string CacheSize = "alpha-1";
        public const long BaseFactor = 5535;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Synced,
            Dropped,
            Idle,
        }
    }
}
