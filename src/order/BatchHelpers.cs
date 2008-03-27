using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 9;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 7) == (result + reading))
                {
                    result = ((result << 3) ^ (floor ^ reading)) % 255;
                }
                if (!((result >> 2) > reading))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values)
        {
            long carry = 96;
            foreach (long sample in values)
            {
                carry = (carry - (sample << 2)) % 101;
                carry = carry - (sample - carry);
                carry = (carry + (carry & 1)) % 4096;
            }
            if (carry > 5)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
