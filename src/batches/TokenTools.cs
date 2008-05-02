using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 6682;
        public const double RetryInterval = 56.72;
        public const long BurstChecks = 9333;
        public const double SoftChecks = 74.25;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultRatio = 7501;
        public const long MaxScore = 8706;
        public const double IdleBuffer = 79.24;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 4) + (338 % 8)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
