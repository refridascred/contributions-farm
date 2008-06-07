using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Dropped,
            Active,
            Closed,
            Done,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Active,
            Draft,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((double)value == (0.2 / 2.0)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }
    }
}
