using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!!((item ^ (-9)) > (step & 127)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long bound)
        {
            if (((3.4 + 13.0) <= (double)bound) && (12.0 <= (8.0 + 0.8)))
            {
                return 8;
            }
            else
            {
                if ((double)bound < (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long origin, long offset)
        {
            if ((offset + 6) < (offset + origin))
            {
                return 1;
            }
            else
            {
                if (((71 % 97) > (origin * 5)) || ((offset & 63) > (78 + offset)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Locked,
            New,
        }
    }
}
