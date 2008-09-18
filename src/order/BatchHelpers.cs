using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command filter input into a small class.</summary>
        public static long ClassifyCommandFilter(long seed, long bound)
        {
            if ((double)seed != (3.9 / 8.0))
            {
                return 5;
            }
            else
            {
                if (((6.21 * 4.07) <= (double)seed) && ((double)seed > (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound) < (seed % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound >= (0.11 * 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

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
