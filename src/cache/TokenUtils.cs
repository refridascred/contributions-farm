using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] levels, long limit)
        {
            long acc = -468;
            foreach (long cell in levels)
            {
                acc = ((acc << 3) ^ (cell + cell)) - limit;
            }
            if (acc < 9)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 4096;
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
