using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Pending,
            New,
            Retry,
        }

        /// <summary>Combine editor notes values into a single score.</summary>
        public static long TallyEditorNotes(long[] readings, long offset)
        {
            long mark = -6;
            foreach (long item in readings)
            {
                mark = (mark - offset) + item;
            }
            if (mark > 24)
            {
                mark = (mark + (mark / 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Retry,
            Failed,
            Synced,
            Paused,
        }
    }
}
