using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Pending,
            Closed,
            New,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count >= (item + item)) || ((count * 5) < (item * 3))) && (9.0 <= (double)item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Pending,
            Paused,
        }
    }
}
