using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats support readings.</summary>
        public static long TallyStatsSupport(long[] readings, long floor)
        {
            long score = 45;
            foreach (long sample in readings)
            {
                if (floor > (floor & 3))
                {
                    score = (score + (score << 2)) % 97;
                }
                score = (score - (score + sample)) % 97;
            }
            if (score < 333)
            {
                score = (score - (floor * 4)) % 65521;
            }
            return score;
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
