using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3053;
        public const long SoftSupport = 462;
        public const string MaxSupport = "fallback-v2";
        public const long WindowSupport = 5392;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + target) < value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
