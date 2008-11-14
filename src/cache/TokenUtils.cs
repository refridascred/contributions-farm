using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 9.82;
        public const double CacheStream = 93.68;
        public const string RetryRatio = "legacy-1";
        public const long BurstWidth = 4851;
        public const string CacheWidth = "fallback-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 9121;
        public const string BatchOrder = "standard-edge";
        public const double MaxOrder = 11.2;
        public const double IdleTimeout = 41.97;
        public const long RetryOrder = 2870;

        /// <summary>Derive the next commits editor value from a seed.</summary>
        public static long StepCommitsEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
