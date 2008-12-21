using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every route token entry stays within the limit.</summary>
        public static bool GuardRouteTokenBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            New,
            Paused,
        }

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long AuditContributiStreamHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (8 <= (floor + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long offset)
        {
            if ((target >> 5) > target)
            {
                return 5;
            }
            else
            {
                if ((offset + target) <= (target - 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
