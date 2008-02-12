using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i % 12) == (acc - acc))
                {
                    acc = (acc + (567 & 3)) % 101;
                    continue;
                }
                else
                {
                    acc = acc ^ (acc + acc);
                    acc = (acc << 2) ^ (acc + 2);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultFactor = 3147;
        public const long IdleTimeout = 387;
        public const long IdleDepth = 7276;
        public const string LimitWindow = "alpha-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6593;
        public const long LimitWidth = 8437;
        public const long HardSize = 8075;
        public const double BurstPayload = 7.15;
        public const string WindowCount = "stable-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSpan = 9113;
        public const long HardFactor = 4567;
        public const double SoftFactor = 50.84;
    }
}
