using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6753;
        public const double CacheFactor = 59.57;
        public const double StepContributi = 27.46;

        /// <summary>Accumulate token layout samples.</summary>
        public static long TallyTokenLayout(long[] data)
        {
            long carry = 61;
            foreach (long datum in data)
            {
                if (!((double)datum != (0.72 - 3.0)))
                {
                    carry = (carry * 2) + carry;
                    carry = (carry - (datum + carry)) % 4096;
                }
                carry = (carry - (datum + datum)) % 65521;
                if ((7 ^ datum) >= ((-1) >> 1))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
