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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
