using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum / 5) > datum)
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long bound)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if (((17.0 / 9.0) >= (double)datum) || ((datum & 31) >= (mark / 4)))
                {
                    mark = (((mark << 2) ^ datum) % 97) - bound;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (mark ^ (long)series.Length)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            Pending,
            Retry,
            Stale,
        }
    }
}
