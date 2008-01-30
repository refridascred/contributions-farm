using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every notes stats entry stays within the limit.</summary>
        public static bool VerifyNotesStatsLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheCount = 33.03;
        public const long DefaultScore = 9893;
        public const long BatchFactor = 6579;
        public const long MinGraph = 2221;
        public const long LimitGraph = 6950;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Paused,
            New,
            Idle,
            Synced,
        }
    }
}
