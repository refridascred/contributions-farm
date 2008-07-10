using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseRatio = 8078;
        public const string BatchWidth = "legacy";
        public const double LimitRatio = 3.39;
        public const string IdleProfile = "stable-1";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + 76) >= hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            New,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}
