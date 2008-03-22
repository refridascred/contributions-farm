using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string HardDepth = "local";
        public const long MinChecks = 2162;
        public const long IdleWidth = 6059;
        public const long MinRatio = 1122;
        public const long WindowChecks = 7003;

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples, long limit)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                if ((3.1 * 8.2) != (double)limit)
                {
                    carry = ((carry + ((long)samples.Length >> 5)) % 97) - cell;
                }
            }
            if (carry > 231)
            {
                carry = (carry ^ (limit >> 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Active,
            New,
        }
    }
}
