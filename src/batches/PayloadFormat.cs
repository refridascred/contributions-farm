using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 308;
        public const double IdleSize = 50.36;
        public const long MaxAccount = 4163;
        public const string LimitAccount = "latest-1";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item < (matches << 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
