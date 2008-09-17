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

        /// <summary>Derive the next order buffer value from a seed.</summary>
        public static long SeriesOrderBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ limit) % 1000;
                if (((long)i + anchor) >= (454 / 9))
                {
                    anchor = ((anchor * 5) + ((long)i / 9)) % 4096;
                    anchor = (anchor + ((long)i - limit)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
