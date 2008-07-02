using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5751;
        public const long SoftQueue = 1322;
        public const long DefaultQueue = 1529;
        public const long WindowQueue = 1048;

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels)
        {
            long result = -996;
            foreach (long item in levels)
            {
                result = (result + result) % 255;
                if ((double)item > (6.5 - 9.0))
                {
                    result = (result - item) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Draft,
            Stale,
            Retry,
        }
    }
}
