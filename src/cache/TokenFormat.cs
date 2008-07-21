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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 43;
            foreach (long sample in values)
            {
                carry = ((carry << 3) ^ (sample + sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 2172;
        public const string BatchInterval = "latest-edge";
        public const long RetryScore = 6923;
    }
}
