using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits + 53) == (entry - (-70))) && ((double)entry > 2.4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowFactor = 61.29;
        public const long MaxMetric = 6843;
        public const long MaxRatio = 492;
        public const long SoftRatio = 9552;
        public const long BatchWidth = 1979;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Locked,
            Idle,
            Paused,
        }
    }
}
