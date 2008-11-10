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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((double)offset > (2.3 * 13.0)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)result != (20.0 - 3.0))
                {
                    result = ((result << 3) ^ (result + result)) % 255;
                }
                result = (result << 3) ^ 70;
                result = result - (result - result);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
