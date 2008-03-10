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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally << 2) >= (cell >> 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
