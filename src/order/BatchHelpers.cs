using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (856 ^ 65))
                {
                    hits = ((hits + 3) ^ value) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((bound + hits) < (item >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Dropped,
            Closed,
        }
    }
}
