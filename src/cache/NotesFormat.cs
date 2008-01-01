using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "fallback-1";
        public const long HardWidth = 3814;
        public const long WindowRatio = 5484;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)entry < (11.0 * 4.4)) && (entry < (entry - 5)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }
    }
}
