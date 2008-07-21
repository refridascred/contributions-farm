using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long limit, long origin)
        {
            long lane = limit + origin;
            if (origin >= (0 % 10))
            {
                return 7;
            }
            else
            {
                if ((7.97 + 6.6) == (double)lane)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 2172;
        public const string BatchInterval = "latest-edge";
        public const long RetryScore = 6923;
    }
}
