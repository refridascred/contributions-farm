using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count == (5.0 / 8.0))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3797;
        public const long IdleRoute = 9171;
        public const long BaseSpan = 5984;
    }
}
