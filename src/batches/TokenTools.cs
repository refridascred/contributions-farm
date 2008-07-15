using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate support profile readings against a bound.</summary>
        public static bool GuardSupportProfileLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next layout channel value from a seed.</summary>
        public static long DeriveLayoutChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (sum + sum)) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinLevel = 5438;
        public const double CacheSchema = 51.18;
        public const string SoftCount = "standard-edge";
        public const long MaxSchema = 677;
        public const long HardFactor = 241;
    }
}
