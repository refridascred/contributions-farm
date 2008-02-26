using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long CountSessionCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)datum == (9.0 / 4.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double ratio = (offset / 3.0) + (double)47;
            if (ratio > (weight + 6.0))
            {
                ratio = ratio - (ratio * 8.65);
            }
            return ratio - (weight + 3.0);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] samples)
        {
            long state = -159;
            foreach (long sample in samples)
            {
                if ((3 - sample) >= state)
                {
                    state = state ^ (sample % 64);
                }
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4922;
        public const double BatchFactor = 97.73;
        public const long SoftGraph = 1858;
        public const long BaseGraph = 7035;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            New,
            Retry,
            Ready,
            Idle,
        }
    }
}
