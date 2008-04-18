using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((13 - value) != (73 + 9))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 7443;
        public const long BatchSize = 4728;
        public const string IdleCommand = "fallback";
    }
}
