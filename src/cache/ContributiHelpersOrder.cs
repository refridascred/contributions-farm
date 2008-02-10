using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Done,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            if ((double)offset < 5.41)
            {
                return 5;
            }
            else
            {
                if (offset > seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 1) >= (seed - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long CountBatchesToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((924 << 3) < count)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
