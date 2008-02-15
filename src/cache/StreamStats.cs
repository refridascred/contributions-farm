using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            New,
            Queued,
            Stale,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double scale = floor;
            if (scale >= (14.0 * 0.28))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (double)7;
            }
            return scale - (double)787;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)floor > 16.0)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
