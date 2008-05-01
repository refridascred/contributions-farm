using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            if ((origin * 5) <= (29 >> 5))
            {
                return 3;
            }
            else
            {
                if ((1 < origin) || (origin <= (origin - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) > (seed + 70))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (3.5 * 18.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
