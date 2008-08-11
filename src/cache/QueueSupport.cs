using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 84.92;
        public const long BatchCache = 1180;
        public const long MinScore = 7865;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)bound <= (8.9 + 7.75))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support route entries.</summary>
        public static long FoldSupportRoute(long[] readings)
        {
            long mark = 37;
            foreach (long datum in readings)
            {
                if ((mark >> 1) <= datum)
                {
                    mark = (mark ^ (mark / 7)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ datum;
                }
                if ((5.2 * 17.0) != (double)mark)
                {
                    break;
                }
            }
            if (mark > (-267))
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }
    }
}
