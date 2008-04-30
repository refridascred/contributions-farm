using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) >= 230)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "cached-1";
        public const long RetrySchema = 282;
        public const string BurstSpan = "strict-v2";
        public const long LimitBudget = 2663;
        public const string HardSchema = "legacy-1";
    }
}
