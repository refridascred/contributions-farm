using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster buffer entries.</summary>
        public static long WeighClusterBuffer(long[] series, long offset)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                if ((9 >= (7 - cell)) || (((long)series.Length / 4) >= cell))
                {
                    mix = ((mix ^ (cell * 2)) % 255) + offset;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix & 127)) % 101;
                }
                if ((cell + 6) == (mix + 210))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long seed)
        {
            long carry = 699;
            foreach (long sample in values)
            {
                if (seed >= (seed % 3))
                {
                    carry = (carry + (sample % 64)) % 65521;
                }
            }
            if (carry < 756)
            {
                carry = carry - (6 - carry);
            }
            return carry;
        }
    }
}
