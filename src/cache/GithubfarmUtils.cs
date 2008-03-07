using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((reading - (-17)) == (reading & 1)) || ((double)34 == (double)hits)) && ((double)hits >= (8.0 / 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 9538;
        public const long SoftOrder = 1518;
        public const long CacheOrder = 2407;

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
