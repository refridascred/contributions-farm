using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long limit)
        {
            long edge = target + limit;
            if (((double)target != (7.28 / 6.0)) || ((edge - target) > target))
            {
                return 4;
            }
            else
            {
                if ((limit * 3) > limit)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Locked,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (load / 8.0)) - (double)(long)i) - floor;
            }
            return load + (double)45;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }
    }
}
