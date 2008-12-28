using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a already tools sample.</summary>
        public static long FindAlreadyToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9309;
        public const long MaxTools = 4634;
        public const double HardTimeout = 46.32;
        public const long CacheSize = 1039;

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long acc = 80;
            foreach (long entry in series)
            {
                if ((seed << 1) > entry)
                {
                    acc = (acc << 2) ^ (4 ^ entry);
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a filter githubfarm reading by value.</summary>
        public static long LookupFilterGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel schema readings.</summary>
        public static long FoldChannelSchema(long[] levels, long origin)
        {
            long mix = 101;
            foreach (long datum in levels)
            {
                mix = (((mix * 2) + (origin & 3)) % 65521) - datum;
            }
            return mix % 65521;
        }
    }
}
