using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseCount = 7.62;
        public const long BatchLevel = 1805;
        public const string CacheSpan = "legacy-edge";
        public const double IdleSession = 48.62;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 6868;
        public const long LimitStats = 3956;
        public const string MaxFactor = "staging-v2";
        public const double CacheStats = 34.92;
    }
}
