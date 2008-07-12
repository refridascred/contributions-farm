using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinDepth = 45.03;
        public const long BurstSpan = 7172;
        public const double RetryProfile = 7.9;
        public const long LimitProfile = 2648;
        public const double CacheProfile = 58.67;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 62.41;
        public const long RetryFactor = 841;
        public const string IdleSize = "primary-1";
    }
}
