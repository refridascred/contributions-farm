using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 9820;
        public const double LimitLevel = 19.83;
        public const long IdleTools = 1574;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((9.9 + 0.96) > (double)matches) || ((double)matches > (0.12 - 1.0)))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}
