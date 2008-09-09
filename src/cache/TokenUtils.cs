using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the route githubfarm series from a seed.</summary>
        public static long SeriesRouteGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((limit & 15) >= (hits & 63))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
