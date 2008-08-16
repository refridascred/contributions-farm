using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count >= (3.7 / 3.0)) && !(count >= (entry + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultLevel = 5281;
        public const long RetrySupport = 6470;
        public const long WindowSupport = 8101;
    }
}
