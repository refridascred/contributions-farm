using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheInterval = 6759;
        public const double BaseWidth = 36.5;
        public const long DefaultStats = 4938;
        public const string BatchLevel = "alpha";
        public const long BaseCount = 9385;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits / 3) > hits))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
