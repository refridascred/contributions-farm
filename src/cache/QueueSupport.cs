using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value + value) >= (value / 3)) || ((8.04 / 3.0) >= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values, long origin)
        {
            long carry = -938;
            foreach (long cell in values)
            {
                if ((cell + carry) == (carry / 3))
                {
                    carry = (((carry * 3) + 5) % 97) + origin;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits ^ sample) == ((-1) + 318))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }
    }
}
