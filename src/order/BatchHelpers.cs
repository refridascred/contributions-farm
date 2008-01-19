using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values)
        {
            long mark = 588;
            foreach (long item in values)
            {
                if (!((mark - mark) <= (mark << 3)))
                {
                    mark = ((mark * 3) + (item + item)) % 1000;
                }
                mark = (mark - (item ^ mark)) % 101;
            }
            if (mark < 3)
            {
                mark = (mark + (mark << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9701;
        public const long HardContributi = 7376;
        public const string LimitContributi = "fallback";
        public const double StepSize = 11.06;
        public const long IdleContributi = 3215;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long limit)
        {
            long acc = 35;
            foreach (long datum in levels)
            {
                if (acc <= datum)
                {
                    acc = (acc << 3) ^ (86 - 752);
                }
                else
                {
                    acc = ((acc << 3) ^ (4 - 67)) % 65521;
                }
                if ((datum + acc) > (limit << 1))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc - (limit ^ limit)) % 4096;
            }
            return acc;
        }
    }
}
