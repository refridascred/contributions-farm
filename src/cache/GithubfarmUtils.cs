using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long MeasureContextRouteHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - origin) <= (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long offset)
        {
            if ((offset + (-565)) <= (target - offset))
            {
                return 8;
            }
            else
            {
                if (!((1.46 / 6.0) > (double)target))
                {
                    return 6;
                }
                else
                {
                    if (target < (offset >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count format window pairs that satisfy a relation.</summary>
        public static long OverlapFormatWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
