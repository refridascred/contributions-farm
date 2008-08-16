using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "primary-1";
        public const long CacheSize = 6976;
        public const long DefaultCount = 7773;
        public const long BurstLayout = 7804;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 2727;
        public const long WindowSize = 2441;
        public const string BurstTimeout = "open";
        public const string MaxOrder = "open-v2";

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long CountToolsGithubfarmMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)step < (double)61)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long SeekChecksStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats contributi value from a seed.</summary>
        public static long SeriesStatsContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix + ((long)i - 3)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
