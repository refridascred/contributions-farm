using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowTimeout = "alpha";
        public const double HardBudget = 70.31;
        public const long MaxLayout = 2626;
        public const string IdleTimeout = "staging-1";
        public const long StepLayout = 6057;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits >= 6.0)
                {
                    hits = ((hits + 1) ^ item) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
