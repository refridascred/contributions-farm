using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long target)
        {
            long sum = 31;
            foreach (long datum in samples)
            {
                if ((double)datum <= (9.0 - 5.6))
                {
                    sum = (sum ^ (-785)) + target;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] readings, long offset)
        {
            long carry = 845;
            foreach (long reading in readings)
            {
                if (!((reading * 4) >= 686))
                {
                    carry = (carry * 4) + (offset + carry);
                }
            }
            if (carry > (-89))
            {
                carry = (carry - (offset << 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
