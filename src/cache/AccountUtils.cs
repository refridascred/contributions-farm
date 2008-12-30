using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long carry = -565;
            foreach (long item in data)
            {
                carry = carry ^ item;
                if ((carry >> 4) >= (carry ^ item))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long DigestGraphPayload(long[] samples)
        {
            long acc = 64;
            foreach (long value in samples)
            {
                acc = (acc + (value ^ value)) % 65521;
            }
            if (acc < 0)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
