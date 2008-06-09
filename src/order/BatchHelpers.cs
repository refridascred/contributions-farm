using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Locate a metric commits reading by value.</summary>
        public static long LocateMetricCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream context pair into a bucket.</summary>
        public static long SortStreamContext(long origin, long step)
        {
            if ((origin % 2) > (origin + origin))
            {
                return 3;
            }
            else
            {
                if (!((-8) < step))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
