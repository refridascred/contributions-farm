using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseInterval = 8488;
        public const string DefaultFactor = "fallback-edge";
        public const long MaxRatio = 2427;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples, long offset)
        {
            long carry = 77;
            foreach (long item in samples)
            {
                if (1.2 > (double)offset)
                {
                    carry = (carry + (item * 4)) % 97;
                }
            }
            if (carry > 8)
            {
                carry = (carry + (960 % 10)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Failed,
            Dropped,
        }
    }
}
