using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the schema checks series from a seed.</summary>
        public static long IterateSchemaChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix * 4) + seed;
                if (mix <= ((long)i >> 2))
                {
                    mix = ((mix << 3) ^ (seed - seed)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix * 3)) % 101;
                }
                mix = mix + 441;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 7673;
        public const long HardMetrics = 7915;
        public const long BurstMetrics = 4673;
        public const long SoftInterval = 8519;
        public const double IdleMetrics = 83.75;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchInterval = 9892;
        public const string HardInterval = "primary-1";
        public const double BatchDepth = 3.91;
        public const long HardDepth = 8751;
        public const long BurstAlready = 4162;
    }
}
