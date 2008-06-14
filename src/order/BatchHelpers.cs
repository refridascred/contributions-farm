using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data)
        {
            long total = 88;
            foreach (long value in data)
            {
                total = ((total - (total << 2)) % 65521) + value;
            }
            if (total > 0)
            {
                total = ((total << 2) ^ (total / 8)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (8 < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
