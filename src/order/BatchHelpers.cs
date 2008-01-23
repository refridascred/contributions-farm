using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long state = 95;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (state - state)) + reading;
            }
            return state;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items, long offset)
        {
            long carry = 66;
            foreach (long reading in items)
            {
                if (carry > reading)
                {
                    carry = ((carry + (carry & 63)) % 1000) + offset;
                }
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if (((5.18 - 5.57) > (double)carry) || ((datum & 3) >= (carry * 2)))
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry % 65521;
        }
    }
}
