using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 1138;
        public const long BurstFactor = 3822;
        public const long StepBudget = 2502;
        public const long LimitWidth = 299;
        public const long LimitCount = 9750;

        /// <summary>Measure how many session commits samples are out of range.</summary>
        public static long CountSessionCommitsOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)floor > (15.0 + 18.0))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Idle,
            Draft,
            Dropped,
        }
    }
}
