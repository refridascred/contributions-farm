using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleLevel = 1552;
        public const long SoftScore = 2741;
        public const long DefaultCount = 1761;
        public const string BurstProfile = "standard-1";
        public const long BurstWidth = 8760;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
