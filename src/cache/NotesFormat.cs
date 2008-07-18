using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long CountStatsContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(460 >= (item * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleSpan = "alpha";
        public const long BatchBatches = 2277;
        public const string BurstSize = "local";
        public const long SoftBatches = 2199;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
