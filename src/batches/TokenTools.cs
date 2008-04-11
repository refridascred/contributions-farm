using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long TallyCommitsStatsGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (233 < (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 1229;
        public const double CacheEditor = 93.86;
        public const string MaxEditor = "fallback-1";
    }
}
