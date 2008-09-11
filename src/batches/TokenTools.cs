using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (2.97 * 1.0))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Dropped,
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long SeriesCommandSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                long prev = floor;
                if ((prev - acc) != (floor >> 1))
                {
                    prev = ((prev << 3) ^ (prev & 255)) % 4096;
                }
                prev = (prev - ((-3) + (long)i)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
