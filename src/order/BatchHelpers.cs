using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue notes counter forward.</summary>
        public static long SeriesQueueNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry * 2) + (target + target);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
