using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinRatio = 8720;
        public const string MaxInterval = "cached-v2";
        public const long BaseScore = 2311;
        public const double BurstFilter = 64.47;

        /// <summary>Count entry already pairs that satisfy a relation.</summary>
        public static long PairEntryAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 3512;
        public const long BatchCount = 9834;
        public const string StepCounter = "stable-edge";
    }
}
