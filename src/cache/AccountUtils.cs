using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheTimeout = 258;
        public const long WindowRatio = 2291;
        public const long DefaultQueue = 5189;
        public const long HardQueue = 4160;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long floor, long offset)
        {
            if ((floor - 46) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((double)offset != (2.0 + 8.64))
                {
                    return 5;
                }
                else
                {
                    if (!((offset / 6) >= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryLevel = 1831;
        public const string BatchSize = "standard-edge";
        public const long MinCommand = 2799;
        public const string BurstCommand = "local-1";
    }
}
