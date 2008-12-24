using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load + scale;
            }
            else
            {
                load = load + offset;
            }
            return load - offset;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank metrics format input into a small class.</summary>
        public static long RankMetricsFormat(long seed, long bound)
        {
            if ((bound & 31) >= (seed - bound))
            {
                return 1;
            }
            else
            {
                if ((4 - bound) <= (-1))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardScore = 9874;
        public const long MaxRecord = 6929;
        public const long DefaultRecord = 2636;
        public const string IdleTimeout = "strict-edge";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Stale,
            Closed,
        }
    }
}
