using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            if ((origin + bound) >= origin)
            {
                return 6;
            }
            else
            {
                if ((bound ^ origin) <= (bound - origin))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
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
