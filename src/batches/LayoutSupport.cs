using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 53.4;
        public const long BatchBuffer = 4322;
        public const double StepRatio = 30.26;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long origin)
        {
            long gap = bound + origin;
            if (gap > (origin - origin))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Dropped,
            Stale,
            Idle,
        }
    }
}
