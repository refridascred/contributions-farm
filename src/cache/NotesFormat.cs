using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Idle,
            New,
            Stale,
        }

        /// <summary>Audit channel metrics readings against a rule.</summary>
        public static long AuditChannelMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches & 7) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
