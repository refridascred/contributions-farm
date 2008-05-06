using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Pending,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardRatio = 3834;
        public const double RetryToken = 59.49;
        public const string HardToken = "fallback-1";
        public const long MaxToken = 9005;
        public const long SoftWidth = 1325;

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 16.26;
        public const long IdleChannel = 5475;
        public const long MaxChannel = 6431;
        public const string BatchDepth = "standard-1";
    }
}
