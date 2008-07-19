using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the window stats entries that pass the check.</summary>
        public static long AuditWindowStatsGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - count) < (757 - target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long origin)
        {
            long anchor = 9;
            foreach (long cell in items)
            {
                if (!((cell >> 1) != (anchor << 2)))
                {
                    anchor = ((anchor - (cell % 24)) % 97) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            New,
            Pending,
        }
    }
}
