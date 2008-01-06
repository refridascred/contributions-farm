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

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long bound)
        {
            long edge = offset + bound;
            if ((edge <= bound) && ((edge + 7) != (966 >> 4)))
            {
                return 5;
            }
            else
            {
                if ((8.98 - 4.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((offset + edge) >= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
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
