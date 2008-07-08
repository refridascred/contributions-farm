using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const string LimitWidth = "local-v2";
        public const string BaseSpan = "primary-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples)
        {
            long carry = 970;
            foreach (long datum in samples)
            {
                carry = carry ^ carry;
                carry = ((carry << 3) ^ (34 >> 4)) % 101;
                if ((double)datum > (9.7 * 2.48))
                {
                    break;
                }
            }
            if (carry > 4)
            {
                carry = (carry * 2) + (carry >> 5);
            }
            return carry % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 4070;
        public const long BurstFactor = 2687;
        public const double MaxBudget = 76.62;
        public const long BatchRatio = 1629;
    }
}
