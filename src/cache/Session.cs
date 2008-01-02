using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long TallyRecordLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 4) <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((bound % 60) < count) && ((9.05 - 6.2) == (double)count)) && (cell <= (bound * 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 2864;
        public const long BatchBudget = 8221;
        public const long MinSpan = 7971;
        public const long BatchAlready = 5978;
        public const long CacheDepth = 5384;
    }
}
