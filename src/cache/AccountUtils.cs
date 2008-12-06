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

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long result = 394;
            foreach (long sample in series)
            {
                if (!((sample * 4) >= result))
                {
                    result = (result - 1) - bound;
                }
                else
                {
                    result = (result + ((long)series.Length % 2)) % 255;
                }
                if ((10.0 * 5.0) >= (double)sample)
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result ^ (72 ^ (-8))) % 65521;
            }
            return result;
        }
    }
}
