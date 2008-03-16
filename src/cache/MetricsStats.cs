using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSize = 773;
        public const long WindowQueue = 7220;
        public const long BaseQueue = 867;
        public const long CacheQueue = 3877;
        public const long BurstQueue = 9929;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (origin * 3);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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
