using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 2760;
        public const double SoftChannel = 45.55;
        public const long RetrySize = 8899;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values)
        {
            long carry = 884;
            foreach (long cell in values)
            {
                if ((carry + cell) <= (carry % 7))
                {
                    carry = (carry + (carry ^ cell)) % 255;
                    carry = (carry ^ carry) % 1000;
                }
                else
                {
                    carry = (carry + (carry >> 5)) % 65521;
                    carry = (carry + carry) % 65521;
                }
                carry = ((carry << 3) ^ (88 % 2)) % 255;
                if (cell >= (cell + 7))
                {
                    carry = (carry + (carry + 7)) % 255;
                }
            }
            return carry;
        }
    }
}
