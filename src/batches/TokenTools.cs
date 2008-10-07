using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a batch session counter forward.</summary>
        public static long SeriesBatchSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound - state) < (bound ^ bound))
                {
                    state = state + (bound + bound);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3673;
        public const long MinFactor = 3145;
        public const long BatchFormat = 2053;
        public const long HardFormat = 909;
        public const long SoftRatio = 1110;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6975;
        public const long DefaultLevel = 2888;
        public const long WindowSpan = 3806;
        public const long WindowTimeout = 4864;
    }
}
