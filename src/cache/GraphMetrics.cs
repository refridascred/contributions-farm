using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Queued,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double rate = floor;
            if (rate >= (scale + floor))
            {
                rate = rate + (double)62;
            }
            else
            {
                rate = rate + (double)6;
            }
            return rate - (floor * 9.3);
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings, long seed)
        {
            long state = 610;
            foreach (long datum in readings)
            {
                if ((datum % 3) < (datum & 255))
                {
                    state = (((state * 2) + state) % 65521) + seed;
                }
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 3372;
        public const long WindowStats = 9351;
        public const long BaseRatio = 6639;
    }
}
