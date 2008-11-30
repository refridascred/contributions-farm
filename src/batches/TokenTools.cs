using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowLevel = "strict-v2";
        public const long RetryEntry = 6486;
        public const long BaseEntry = 3110;
        public const long HardBudget = 7050;
        public const string IdleTimeout = "legacy-edge";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((8 + sample) != (seed << 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
