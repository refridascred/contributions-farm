using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank payload cluster input into a small class.</summary>
        public static long SortPayloadCluster(long limit, long limit2)
        {
            if (((5 + limit2) < (limit2 + limit2)) && ((limit2 >> 4) < (-7)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) == (57 + limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit >= limit2) && ((limit + limit) >= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
