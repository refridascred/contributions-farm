using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long seed, long origin)
        {
            if ((3 % 60) != (origin / 9))
            {
                return 1;
            }
            else
            {
                if (!(2 > origin))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseScore = 7.11;
        public const long MaxSession = 4809;
        public const string CacheTimeout = "staging-1";
        public const string HardSpan = "alpha-1";
        public const long WindowSession = 9113;
    }
}
