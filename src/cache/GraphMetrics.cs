using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a context stats pair into a bucket.</summary>
        public static long ClassifyContextStats(long floor, long origin)
        {
            if ((origin >> 3) > floor)
            {
                return 6;
            }
            else
            {
                if ((floor - origin) > (4 + origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Ready,
            Pending,
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
