using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Idle,
            Done,
            Queued,
            New,
        }

        /// <summary>Count the metrics commits entries that pass the check.</summary>
        public static long AuditMetricsCommitsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((reading >> 5) == (725 - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry entry stays within the limit.</summary>
        public static bool ValidateQueueEntryRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
