using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long origin)
        {
            if ((limit + limit) == (784 << 2))
            {
                return 3;
            }
            else
            {
                if (((7.8 + 7.28) != (double)origin) || ((double)limit == (4.0 * 0.9)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (11.0 * 4.19))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((772 << 3) > (4 + hits)) || ((hits + 765) < (item - hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!(limit > (total & 7)))
                {
                    total = (total << 3) ^ (total / 8);
                }
                total = total + total;
                total = (total - limit) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
