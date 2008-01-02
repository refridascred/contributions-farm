using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark + 772) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 9835;
        public const long WindowStream = 392;
        public const long SoftStream = 7176;

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitLevel = 1131;
        public const long MaxMetric = 4689;
        public const long BurstCount = 2152;
        public const long RetryBudget = 9787;
        public const long BaseTimeout = 5315;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardLevel = 6221;
        public const string CacheInterval = "open-1";
        public const string BaseInterval = "staging-v2";
        public const long StepCount = 1854;
    }
}
