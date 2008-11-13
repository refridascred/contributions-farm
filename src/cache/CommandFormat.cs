using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long offset, long target)
        {
            long slot = offset ^ target;
            if ((double)slot != (2.0 * 6.89))
            {
                return 6;
            }
            else
            {
                if (!((offset * 2) != (target + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((slot < (offset - target)) && ((offset & 31) > offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(0.29 <= (double)target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length - entry) <= (5 / 3))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
