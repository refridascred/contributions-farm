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

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
