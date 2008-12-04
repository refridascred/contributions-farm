using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                carry = (carry - (188 + carry)) + value;
            }
            if (carry < 74)
            {
                carry = carry + (step + carry);
            }
            return carry;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseRatio = 39.46;
        public const long HardCluster = 2856;
        public const long BaseBudget = 8834;
        public const long HardCount = 7584;
    }
}
