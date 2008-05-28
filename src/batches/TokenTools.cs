using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long TallyStatsCacheHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > (matches + matches))
                {
                    matches = ((matches + 3) ^ cell) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 7627;
        public const double HardEditor = 98.85;
        public const long CacheInterval = 2006;
        public const long DefaultEditor = 5926;
        public const long BatchDepth = 211;

        /// <summary>Derive the next window format value from a seed.</summary>
        public static long IterateWindowFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (acc << 2);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
