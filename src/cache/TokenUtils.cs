using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item >= (155 * 4))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Dropped,
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Synced,
            Retry,
            Ready,
            Queued,
        }
    }
}
