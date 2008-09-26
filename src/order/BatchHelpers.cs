using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value & 63) <= ((-90) + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)5 <= (double)entry)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
