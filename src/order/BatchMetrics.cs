using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long bound, long limit)
        {
            long delta = bound + limit;
            if (((delta ^ limit) > limit) || ((bound / 7) < (87 - delta)))
            {
                return 3;
            }
            else
            {
                if ((969 + delta) == (limit + limit))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxTimeout = 20.16;
        public const double MinSize = 26.75;
        public const string BurstToken = "open-edge";

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "fallback-v2";
        public const double StepCount = 18.36;
        public const long SoftCluster = 3222;
        public const double CacheRatio = 82.82;
        public const double RetryCluster = 73.54;
    }
}
