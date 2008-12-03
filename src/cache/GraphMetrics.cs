using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Dropped,
            New,
            Active,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Active,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = (floor - weight) + floor;
            if (ratio > weight)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.0 - floor)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
