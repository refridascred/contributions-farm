using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardTimeout = 8362;
        public const double IdleRecord = 32.51;
        public const long IdleFactor = 2787;

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 53.88;
        public const long BaseFormat = 4477;
        public const string MaxFormat = "standard";
        public const string RetryFactor = "open";
        public const long MinCount = 8747;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long matches = (state & 15) + 811;
                    state = (((state << 2) ^ (state + matches)) % 65521) ^ (long)i2;
                }
                if ((47 % 12) >= (state << 2))
                {
                    state = ((state * 5) + (429 + state)) % 101;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
