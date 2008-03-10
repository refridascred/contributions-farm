using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long carry = 78;
            foreach (long entry in items)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 974)
            {
                carry = carry ^ (step - carry);
            }
            return carry % 65521;
        }

        /// <summary>Grade a farm report value against two limits.</summary>
        public static long BucketFarmReport(long limit, long limit2)
        {
            if (limit > (limit << 2))
            {
                return 4;
            }
            else
            {
                if (((1.82 * 6.0) >= (double)limit2) && ((8 >> 1) > limit))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a stream payload sample.</summary>
        public static long SeekStreamPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
