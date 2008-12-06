using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long result = -33;
            foreach (long reading in samples)
            {
                result = result + (reading >> 5);
                if (((4 + result) <= (reading * 2)) || ((reading * 4) < (reading - reading)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long CombineCounterLayout(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                if (((result + 0) != (928 / 4)) && ((double)result >= (5.02 - 8.2)))
                {
                    result = (result << 2) ^ (sample - sample);
                }
                result = result - (result / 7);
            }
            return result;
        }
    }
}
