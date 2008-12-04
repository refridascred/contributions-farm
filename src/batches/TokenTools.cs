using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstScore = 1154;
        public const long CacheToken = 7680;
        public const long IdleToken = 3492;
        public const long HardToken = 7307;
        public const double LimitToken = 51.42;

        /// <summary>Rank session already input into a small class.</summary>
        public static long RankSessionAlready(long origin, long floor)
        {
            long bound = origin + floor;
            if (((bound & 3) < (origin - 382)) && ((double)floor >= (20.0 - 0.5)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ floor) != (271 + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 5) >= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepSize = "fallback-edge";
        public const double RetryGraph = 27.29;
        public const long MinGraph = 6945;
    }
}
