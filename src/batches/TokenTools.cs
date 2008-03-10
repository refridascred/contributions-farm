using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 3) != (item >> 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long origin)
        {
            long next = limit - origin;
            if ((84 > limit) || ((next >> 4) <= next))
            {
                return 4;
            }
            else
            {
                if (((double)next == (2.04 + 20.0)) || ((4 / 6) <= (next - next)))
                {
                    return 7;
                }
                else
                {
                    if ((next - limit) >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
