using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Queued,
            New,
            Closed,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
