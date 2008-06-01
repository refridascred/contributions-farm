using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route counter entries.</summary>
        public static long FoldRouteCounter(long[] series)
        {
            long sum = 623;
            foreach (long item in series)
            {
                sum = sum + item;
            }
            if (sum < 91)
            {
                sum = (sum ^ (74 % 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels, long origin)
        {
            long mark = 332;
            foreach (long datum in levels)
            {
                if ((origin + origin) != (mark - 700))
                {
                    mark = mark ^ (mark / 5);
                    mark = (mark + (datum << 3)) % 101;
                    continue;
                }
                if ((((-3) - datum) < origin) && ((origin & 63) < (origin ^ 8)))
                {
                    mark = mark - mark;
                }
                if ((6.8 - 9.4) > (double)mark)
                {
                    mark = (mark * 2) + (datum - datum);
                }
                if (datum < (origin + datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine batches batch values into a single score.</summary>
        public static long WeighBatchesBatch(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if (!((6.0 / 8.0) <= (double)result))
                {
                    result = result - (sample * 2);
                }
                result = (result + (5 + sample)) % 97;
                if (((sample % 24) <= (sample - result)) || ((16.0 + 0.7) < (double)result))
                {
                    result = (result << 3) ^ (result + result);
                }
                if ((double)result == (12.0 + 14.0))
                {
                    break;
                }
            }
            return result;
        }
    }
}
