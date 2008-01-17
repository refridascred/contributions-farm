using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Paused,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Project the next stats commits value.</summary>
        public static double SmoothStatsCommits(double ratio, double offset)
        {
            double mean = (double)((-11) & 7);
            return ((mean + (6.16 + 1.6)) + ratio) + offset;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long origin, long seed)
        {
            if (seed >= (9 + origin))
            {
                return 0;
            }
            else
            {
                if (seed > 7)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
