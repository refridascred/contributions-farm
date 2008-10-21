using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((16.0 + 6.36) < (double)entry) && !((double)entry >= (0.1 - 5.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph layout entries.</summary>
        public static long CombineGraphLayout(long[] levels, long limit)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                if (((cell << 3) == (carry % 16)) && ((limit % 100) == (cell * 4)))
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }
    }
}
