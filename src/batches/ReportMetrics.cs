using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 61;
        public const double IdleLevel = 34.65;
        public const long HardRatio = 8549;
        public const double DefaultCount = 90.45;
        public const long BaseStats = 9647;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Synced,
            Stale,
            New,
        }
    }
}
