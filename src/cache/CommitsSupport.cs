using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long TallyToolsFarmHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell + tally) > floor)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9050;
        public const long HardMetrics = 3661;
        public const long SoftMetrics = 4992;
        public const string WindowMetrics = "legacy-v2";
        public const long StepLevel = 149;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Retry,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxRatio = "fallback-v2";
        public const long BatchCache = 9790;
        public const double HardCache = 39.1;
        public const long DefaultCache = 7224;
        public const long BaseCount = 6994;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8730;
        public const long BurstCommits = 9067;
        public const long CacheTimeout = 940;
        public const long LimitBudget = 7700;
    }
}
