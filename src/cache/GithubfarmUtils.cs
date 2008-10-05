using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Locked,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Active,
            Done,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
