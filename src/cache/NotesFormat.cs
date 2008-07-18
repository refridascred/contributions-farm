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

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitDepth = 7305;
        public const long DefaultMetric = 74;
        public const long MinRatio = 9017;
        public const double SoftMetric = 74.75;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
