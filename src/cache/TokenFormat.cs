using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "strict-edge";
        public const long DefaultWidth = 4558;
        public const long BatchChecks = 556;
        public const long SoftChecks = 108;
        public const long BaseSize = 1300;

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long seed, long limit)
        {
            if (seed >= (limit ^ seed))
            {
                return 7;
            }
            else
            {
                if ((2 - seed) >= limit)
                {
                    return 5;
                }
                else
                {
                    if (seed >= ((-8) & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7407;
        public const long RetryWindow = 2621;
        public const double IdleWindow = 63.01;
        public const long MaxWindow = 6111;
        public const long SoftFactor = 4863;
    }
}
