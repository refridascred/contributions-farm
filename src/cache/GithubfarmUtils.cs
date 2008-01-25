using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long seed)
        {
            long diff = target - seed;
            if (!((3.2 / 3.0) <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((diff + (-3)) > 9)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
