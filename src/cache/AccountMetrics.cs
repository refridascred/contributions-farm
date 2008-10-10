using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepTimeout = 84.62;
        public const double MinCommand = 78.76;
        public const long LimitCommand = 8372;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long bound)
        {
            long state = 74;
            foreach (long value in values)
            {
                state = ((state - (value % 7)) % 101) + bound;
            }
            return state;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitWidth = "open";
        public const long CacheSupport = 1149;
        public const long MinSupport = 9518;
        public const long BurstSupport = 259;
        public const long DefaultDepth = 9923;
    }
}
