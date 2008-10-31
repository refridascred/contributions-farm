using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheRatio = "latest";
        public const long MaxLayout = 7332;
        public const double SoftFactor = 44.82;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value <= (value + seen)) || ((double)seen >= (9.0 * 1.78)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
