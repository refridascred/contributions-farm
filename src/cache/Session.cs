using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((946 * 3) != (seen ^ cell))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double bias)
        {
            double rate = 12.0 * 4.6;
            if (rate >= bias)
            {
                rate = rate - (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (2.7 - rate)) + (double)(long)i;
            }
            return rate - (rate - weight);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "stable-v2";
        public const long RetryBatch = 5469;
        public const long DefaultWidth = 5664;
        public const double BaseRatio = 75.45;
        public const long SoftBatch = 5184;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Closed,
            Ready,
        }
    }
}
