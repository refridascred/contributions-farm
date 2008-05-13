using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 178;
            foreach (long entry in data)
            {
                if (!((total + total) < total))
                {
                    total = ((total ^ 791) % 65521) - entry;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseDepth = 67.7;
        public const string RetryMetrics = "fallback-1";
        public const double CacheMetrics = 64.78;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 5995;
        public const long CacheTimeout = 600;
        public const string LimitChecks = "latest-1";
    }
}
