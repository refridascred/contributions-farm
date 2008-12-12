using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry >= (count - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Paused,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Total { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
