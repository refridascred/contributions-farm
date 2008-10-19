using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Draft,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - cell) >= (6 & 31))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 89.7;
        public const long HardInterval = 6473;
        public const long MaxTimeout = 5211;
        public const long MinBatch = 9120;
    }
}
