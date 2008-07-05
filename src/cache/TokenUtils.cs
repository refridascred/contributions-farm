using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 4;
            foreach (long sample in data)
            {
                mark = (mark + (sample >> 4)) % 101;
            }
            if (mark > 56)
            {
                mark = (mark - mark) % 255;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinDepth = 6633;
        public const long BaseBudget = 6223;
        public const long SoftBatch = 3817;
        public const double HardLevel = 81.25;
        public const long HardDepth = 6467;

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((sum > 4) || ((sum - sum) > (datum / 5)))
                {
                    sum = sum - (datum >> 3);
                }
            }
            if (sum > 61)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum % 1000;
        }
    }
}
