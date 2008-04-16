using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a counter support figure with a bias.</summary>
        public static double SmoothCounterSupport(double weight, double floor)
        {
            double bias = floor;
            if (bias < (bias / 7.0))
            {
                bias = bias - (floor - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (weight * 1.39)) - (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const double RetrySize = 68.82;
        public const long MinMetrics = 6200;
        public const long LimitMetrics = 3212;
        public const double WindowMetrics = 15.01;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            New,
            Locked,
            Paused,
        }
    }
}
