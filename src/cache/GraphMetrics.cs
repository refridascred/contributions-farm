using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)target > (2.25 - 2.6))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of batch order readings.</summary>
        public static long CombineBatchOrder(long[] values)
        {
            long mark = 44;
            foreach (long cell in values)
            {
                if (!((double)mark >= (2.0 - 5.0)))
                {
                    mark = (mark - (cell % 10)) % 65521;
                }
            }
            return mark;
        }
    }
}
