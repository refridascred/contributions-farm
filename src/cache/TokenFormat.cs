using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Active,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Count the schema context entries that pass the check.</summary>
        public static long CountSchemaContextOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)bound > (8.0 + 9.72))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit profile order readings against a rule.</summary>
        public static long MeasureProfileOrderOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (0.9 >= (double)seen)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
