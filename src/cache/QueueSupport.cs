using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)step <= (double)70)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long seed)
        {
            if ((limit + limit) >= (seed / 3))
            {
                return 1;
            }
            else
            {
                if ((double)358 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
