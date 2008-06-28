using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "alpha-1";
        public const long BurstRoute = 4021;
        public const long WindowRoute = 560;
        public const long MinLevel = 3008;
        public const double DefaultInterval = 0.83;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = ((score << 2) ^ score) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 8014;
        public const long BaseReport = 9903;
        public const long DefaultSize = 3998;
    }
}
