using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long origin)
        {
            long state = 822;
            foreach (long entry in values)
            {
                state = ((state - (entry / 6)) % 101) + origin;
            }
            if (state < 6)
            {
                state = (state + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long offset)
        {
            long cur = limit - offset;
            if ((offset ^ cur) > offset)
            {
                return 0;
            }
            else
            {
                if ((9.12 * 4.7) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((86 & 15) != (cur << 2)) || (cur < (limit >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Dropped,
            New,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((offset + offset) >= offset) || ((double)offset > (4.0 + 5.0)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
