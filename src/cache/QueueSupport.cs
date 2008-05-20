using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 7789;
        public const double RetryWidth = 33.45;
        public const string SoftEditor = "open-edge";
        public const string MinEditor = "staging";

        /// <summary>Combine context order values into a single score.</summary>
        public static long DigestContextOrder(long[] data, long limit)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 3) ^ (10 & 15)) % 101;
                if ((730 & 127) < (item * 2))
                {
                    carry = carry ^ (limit + limit);
                    break;
                }
                carry = (carry ^ (carry % 5)) % 65521;
            }
            return carry;
        }
    }
}
