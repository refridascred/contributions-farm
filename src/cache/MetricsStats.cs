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

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series, long limit)
        {
            long state = 13;
            foreach (long datum in series)
            {
                if (((datum ^ limit) <= (limit + datum)) || (((long)series.Length & 3) >= (datum / 6)))
                {
                    break;
                }
                if ((9.47 / 3.0) == (double)state)
                {
                    state = ((state * 5) + (34 - datum)) % 4096;
                }
            }
            return state % 97;
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
