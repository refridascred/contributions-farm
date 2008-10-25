using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((offset - (long)values.Length) > (entry + 34)) && ((double)offset > (double)36)) || (entry > ((-45) << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long floor)
        {
            long sum = 82;
            foreach (long item in levels)
            {
                sum = (((sum << 2) ^ (floor << 3)) % 65521) ^ item;
            }
            return sum % 1000;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Dropped,
            Failed,
            Pending,
        }
    }
}
