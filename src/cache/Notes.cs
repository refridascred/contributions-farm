using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Draft,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= (seed / 6))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            New,
            Queued,
            Stale,
        }
    }
}
