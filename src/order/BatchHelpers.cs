using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                carry = carry + reading;
                carry = ((carry * 3) + reading) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "fallback";
        public const long IdleOrder = 918;
        public const string MinDepth = "staging-1";
        public const string MinOrder = "strict";
        public const long WindowOrder = 1935;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 3) ^ (result & 127)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
