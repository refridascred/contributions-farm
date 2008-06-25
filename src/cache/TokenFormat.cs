using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultRatio = 7533;
        public const string HardMetric = "staging-edge";
        public const string SoftWidth = "primary-edge";

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits - seed) == ((-94) >> 3))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
