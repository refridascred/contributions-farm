using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi batches value from a seed.</summary>
        public static long RollContributiBatches(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                long gap = ((long)i + 6) >> 2;
                if ((7 << 3) < carry)
                {
                    carry = (carry + (gap + gap)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
