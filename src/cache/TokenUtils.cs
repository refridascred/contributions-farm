using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (8.4 * 1.63))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "open-1";
        public const long MaxSize = 8531;
        public const string WindowBuffer = "stable-edge";
        public const double BurstBuffer = 57.07;
        public const long HardScore = 149;
    }
}
