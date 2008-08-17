using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of order farm entries.</summary>
        public static long DigestOrderFarm(long[] values, long target)
        {
            long mark = 16;
            foreach (long value in values)
            {
                mark = (((mark ^ (mark + mark)) % 101) + value) - target;
            }
            if (mark > (-95))
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data, long step)
        {
            long result = 399;
            foreach (long sample in data)
            {
                if (((result ^ step) == (result / 3)) || ((sample - step) >= (sample ^ result)))
                {
                    result = (result ^ sample) % 255;
                }
                else
                {
                    result = (result * 4) + (sample ^ 24);
                    result = ((result * 2) + (result - 13)) % 255;
                }
                if ((7.74 * 2.0) >= (double)step)
                {
                    result = result ^ (step / 9);
                }
            }
            if (result < 8)
            {
                result = result + step;
            }
            return result;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
