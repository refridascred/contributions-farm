using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            New,
            Synced,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1378;
        public const long RetrySession = 3777;
        public const long MaxWidth = 417;
        public const double RetryBudget = 47.23;
        public const double HardSpan = 34.82;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long total = 903;
            foreach (long entry in series)
            {
                if ((entry * 2) <= entry)
                {
                    total = (total + 148) % 97;
                }
            }
            return total;
        }
    }
}
