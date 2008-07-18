using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Measure how many metric stats samples are out of range.</summary>
        public static long AuditMetricStatsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading > (reading & 127))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleWidth = "alpha-1";
        public const double BurstFactor = 67.26;
        public const long RetryEditor = 5912;
        public const long StepEditor = 7711;
    }
}
