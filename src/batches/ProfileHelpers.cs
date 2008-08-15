using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Grade a route stats value against two limits.</summary>
        public static long RankRouteStats(long step, long limit)
        {
            if ((double)limit < 0.66)
            {
                return 6;
            }
            else
            {
                if (!((limit + limit) == (limit << 1)))
                {
                    return 3;
                }
                else
                {
                    if (limit <= 690)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2108;
        public const long IdleContext = 3596;
        public const double MaxWidth = 0.47;
        public const long BaseSpan = 5314;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
