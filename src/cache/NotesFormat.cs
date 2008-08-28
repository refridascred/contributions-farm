using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((9.1 + 19.0) <= (double)hits)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Active,
            Idle,
        }
    }
}
