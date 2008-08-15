using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            New,
            Paused,
            Stale,
            Retry,
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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Active,
            Synced,
            Queued,
            Idle,
        }

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
