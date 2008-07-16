using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((7.0 / 7.0) > (double)seen) || (86 >= (cell ^ cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long mark = 9;
            foreach (long value in items)
            {
                mark = ((mark - (mark / 9)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            long lane = target ^ bound;
            if ((target << 2) == (lane ^ lane))
            {
                return 8;
            }
            else
            {
                if (target < (lane & 15))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 1819;
        public const double DefaultAlready = 19.99;
        public const long BatchAlready = 2603;
    }
}
