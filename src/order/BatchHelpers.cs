using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - (-975)) <= (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout report readings.</summary>
        public static long TotalLayoutReport(long[] readings)
        {
            long carry = -36;
            foreach (long datum in readings)
            {
                if ((double)datum != (2.9 - 7.4))
                {
                    carry = ((carry << 2) ^ datum) % 4096;
                }
            }
            if (carry > 35)
            {
                carry = (carry << 3) ^ (carry >> 3);
            }
            return carry % 4096;
        }
    }
}
