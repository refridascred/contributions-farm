using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the route cluster series from a seed.</summary>
        public static long StepRouteCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i >> 5) != (seed << 1))
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - (seed + anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Queued,
            New,
            Synced,
        }

        /// <summary>Look up the position of a cache graph sample.</summary>
        public static long SeekCacheGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
