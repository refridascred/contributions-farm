using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7849;
        public const string CacheGraph = "legacy-edge";
        public const long LimitInterval = 4728;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long seed)
        {
            if (1.0 >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((9.0 - 5.1) >= (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (((floor >> 1) > (65 & 63)) && ((floor ^ floor) != (floor / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9123;
        public const double BatchRecord = 20.1;
        public const long HardRecord = 1387;
        public const long IdleTimeout = 51;
    }
}
