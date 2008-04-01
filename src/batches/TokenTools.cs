using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long step, long bound)
        {
            if ((bound * 3) != (bound % 2))
            {
                return 6;
            }
            else
            {
                if ((bound / 3) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound != (1.88 + 0.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ (state % 60);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 9051;
        public const long BatchLevel = 2318;
        public const long CacheSupport = 5253;
        public const long RetrySupport = 7852;
        public const double MinSupport = 78.9;
    }
}
