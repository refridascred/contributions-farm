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

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 4474;
        public const long MinContributi = 2010;
        public const string SoftFactor = "staging";
        public const long BaseTimeout = 1228;
        public const string RetryContributi = "latest-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 16.26;
        public const long IdleChannel = 5475;
        public const long MaxChannel = 6431;
        public const string BatchDepth = "standard-1";
    }
}
