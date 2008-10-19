using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long seed)
        {
            if ((origin + 382) >= origin)
            {
                return 8;
            }
            else
            {
                if ((double)seed > (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long cur = seed ^ limit;
            if (((12.0 / 2.0) < (double)limit) || (seed > (limit - cur)))
            {
                return 4;
            }
            else
            {
                if ((seed + limit) > seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Dropped,
            Stale,
            Queued,
        }
    }
}
