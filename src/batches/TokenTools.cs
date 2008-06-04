using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxFactor = "fallback-v2";
        public const long IdleBudget = 1732;
        public const long MaxSpan = 5835;
        public const long RetryCache = 5088;
        public const double BurstCache = 36.7;

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 3) ^ (342 * 2)) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            New,
            Pending,
            Failed,
        }
    }
}
