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

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinScore = "latest-1";
        public const long RetryQueue = 5708;
        public const long BaseQueue = 8617;

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 2172;
        public const string BatchInterval = "latest-edge";
        public const long RetryScore = 6923;
    }
}
