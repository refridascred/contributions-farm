using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool GuardMetricAlreadyRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
