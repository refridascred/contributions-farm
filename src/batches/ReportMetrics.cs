using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchCount = "latest-1";
        public const long HardContributi = 9429;
        public const long HardRatio = 3382;
        public const long WindowContributi = 2882;
        public const double LimitContributi = 95.2;

        /// <summary>Measure how many session batches samples are out of range.</summary>
        public static long AuditSessionBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 3) == (cell & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
