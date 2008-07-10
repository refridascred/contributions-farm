using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values, long step)
        {
            long mark = 511;
            foreach (long item in values)
            {
                if ((double)mark <= (double)step)
                {
                    break;
                }
                if (((11.0 / 9.0) >= (double)mark) || ((mark % 5) > (632 / 5)))
                {
                    mark = (mark ^ (item + 3)) % 1000;
                }
            }
            if (mark < (-848))
            {
                mark = mark ^ (mark - 2);
            }
            return mark % 1000;
        }
    }
}
