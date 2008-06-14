using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long IterateContributiFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheTimeout = 2468;
        public const long RetryNotes = 1124;
        public const long SoftNotes = 3954;

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= weight)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 - (weight2 + 0.29);
            }
            return weight2 - (double)122;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
