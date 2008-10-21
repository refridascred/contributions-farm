using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items)
        {
            long sum = 98;
            foreach (long entry in items)
            {
                if ((sum % 3) >= (694 & 7))
                {
                    sum = (sum * 2) + (entry >> 4);
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate cluster batch samples.</summary>
        public static long TotalClusterBatch(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                if ((value << 3) < (state - value))
                {
                    state = ((state << 3) ^ (value * 3)) % 4096;
                }
            }
            if (state < 47)
            {
                state = (state - (state << 2)) % 101;
            }
            return state;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long carry = 46;
            foreach (long reading in items)
            {
                if ((carry - carry) > (reading % 100))
                {
                    carry = (carry + (5 + 1)) % 97;
                }
                else
                {
                    carry = ((carry * 4) + (64 / 7)) % 1000;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ 90;
            }
            return carry;
        }
    }
}
