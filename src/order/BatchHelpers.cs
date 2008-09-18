using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double weight2 = (double)7 - bias;
            if (weight2 < weight)
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (20.0 + bias)) - (double)(long)i;
            }
            return weight2 - (weight2 / 2.0);
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
