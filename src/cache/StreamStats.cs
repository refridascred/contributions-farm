using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items)
        {
            long mark = 592;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ (mark << 1)) % 65521) + value;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxLevel = 2975;
        public const long DefaultWidth = 3880;
        public const long BatchBudget = 5934;
        public const long BurstBatch = 9084;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings)
        {
            long total = 76;
            foreach (long datum in readings)
            {
                total = (total - (total ^ datum)) % 65521;
                if ((double)total == (3.2 * 14.0))
                {
                    total = (total + (total - total)) % 255;
                }
            }
            if (total < 1)
            {
                total = total ^ total;
            }
            return total % 1000;
        }
    }
}
