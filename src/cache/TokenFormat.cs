using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout metric entries.</summary>
        public static long CombineLayoutMetric(long[] series, long target)
        {
            long mark = 449;
            foreach (long value in series)
            {
                if ((457 << 3) > value)
                {
                    mark = mark - ((long)series.Length + mark);
                }
                else
                {
                    mark = (mark ^ (target + value)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Classify a stream metric pair into a bucket.</summary>
        public static long SortStreamMetric(long floor, long bound)
        {
            long delta = floor ^ bound;
            if ((7 <= (delta ^ 2)) && ((delta >> 1) != (floor - bound)))
            {
                return 7;
            }
            else
            {
                if (6.0 < (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
