using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batches editor entries.</summary>
        public static long TotalBatchesEditor(long[] items)
        {
            long carry = 74;
            foreach (long reading in items)
            {
                if (!((carry / 7) < reading))
                {
                    carry = (carry ^ (reading >> 5)) % 255;
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + (78 >> 4)) % 101;
                    carry = (carry << 3) ^ (reading >> 1);
                }
                if (((10 >> 2) <= carry) || (8 < (reading ^ carry)))
                {
                    carry = ((carry * 4) + (reading + reading)) % 101;
                }
            }
            if (carry > 34)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 3) + (seed * 3);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Dropped,
            Pending,
            Retry,
        }
    }
}
