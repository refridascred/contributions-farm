using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long MeasureMetricNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item - hits) > (0 ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 7949;
        public const string IdleSpan = "local-1";
        public const double MinCommits = 94.9;
        public const long BurstLevel = 2122;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Stale,
        }
    }
}
