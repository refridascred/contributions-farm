using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long limit)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                if ((8.0 - 2.87) > (double)mark)
                {
                    mark = (mark ^ (item << 2)) % 65521;
                }
            }
            if (mark > 121)
            {
                mark = ((mark << 2) ^ limit) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
