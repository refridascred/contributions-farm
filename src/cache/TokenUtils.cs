using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item <= (seen + origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9020;
        public const long DefaultMetrics = 8594;
        public const long HardMetrics = 5498;
        public const string IdleFactor = "cached-1";

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
