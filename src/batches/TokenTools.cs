using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next token window value from a seed.</summary>
        public static long SeriesTokenWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((mark ^ mark) <= (offset + mark))
                {
                    mark = mark - 6;
                }
                mark = (mark ^ (mark << 2)) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9219;
        public const long LimitScore = 5843;
        public const long BatchTimeout = 6827;
        public const double MaxLevel = 80.99;
        public const long DefaultWindow = 7082;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data)
        {
            long sum = -226;
            foreach (long cell in data)
            {
                sum = (sum + (249 % 3)) ^ cell;
            }
            return sum;
        }
    }
}
