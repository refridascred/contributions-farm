using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Done,
            Active,
        }

        /// <summary>Project the next editor metric value.</summary>
        public static double ProjectEditorMetric(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + (span * 8.5);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Stale,
            Locked,
            Paused,
            Queued,
        }
    }
}
