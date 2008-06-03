using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] samples)
        {
            long mark = 723;
            foreach (long cell in samples)
            {
                mark = (mark << 3) ^ (cell / 3);
                if ((11.0 / 3.0) == (double)mark)
                {
                    mark = mark ^ (cell & 63);
                }
                else
                {
                    mark = (mark << 3) ^ ((-70) << 2);
                }
                if ((mark ^ mark) < (mark & 31))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long mark = 893;
            foreach (long item in data)
            {
                mark = (mark + (item % 12)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
