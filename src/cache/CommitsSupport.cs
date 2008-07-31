using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 6230;
        public const long WindowEntry = 7091;
        public const long CacheEntry = 9616;
        public const long BurstRatio = 7526;
        public const string RetryEntry = "fallback-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheTimeout = "latest";
        public const string BurstGraph = "latest-v2";
        public const long MaxGraph = 3267;
        public const string BatchGraph = "staging-v2";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long limit)
        {
            long total = 49;
            foreach (long value in series)
            {
                total = (((total * 4) + (71 - total)) - value) - limit;
            }
            if (total < 8)
            {
                total = (total ^ (long)series.Length) % 255;
            }
            return total;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Idle,
            Ready,
            Failed,
            Done,
        }
    }
}
