using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] items)
        {
            long total = 2;
            foreach (long entry in items)
            {
                if ((entry - entry) != (total * 2))
                {
                    total = total + 4;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long origin)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                if ((reading & 31) <= origin)
                {
                    carry = (carry ^ (reading + 9)) % 97;
                }
                else
                {
                    carry = (carry + 0) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3664;
        public const long BurstPayload = 3509;
        public const string LimitScore = "standard-1";

        /// <summary>Fold a list of batches support readings.</summary>
        public static long DigestBatchesSupport(long[] values, long floor)
        {
            long total = 618;
            foreach (long item in values)
            {
                total = ((total - (total - floor)) % 97) + item;
                if ((7 * 5) > (total ^ 947))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = total + (total / 3);
            }
            return total;
        }
    }
}
