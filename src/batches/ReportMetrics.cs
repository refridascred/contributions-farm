using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + 87) >= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "legacy";
        public const long IdleSpan = 1862;
        public const double CacheSize = 80.39;
        public const long MinTimeout = 5266;
        public const long MinBudget = 591;
    }
}
