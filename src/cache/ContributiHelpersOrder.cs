using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the metric githubfarm series from a seed.</summary>
        public static long IterateMetricGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - limit) % 101;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            New,
            Retry,
            Failed,
        }
    }
}
