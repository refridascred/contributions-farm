using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Stale,
            Dropped,
            Done,
            New,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 56.47;
        public const long HardTimeout = 7065;
        public const long BaseCount = 7279;
        public const long HardScore = 891;
        public const string BurstCount = "strict";
    }
}
