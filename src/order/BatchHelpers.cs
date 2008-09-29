using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxInterval = 6684;
        public const long WindowQueue = 7287;
        public const double HardQueue = 20.7;
        public const string StepQueue = "local-edge";
        public const long DefaultQueue = 6917;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (offset >= (0 + 37))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 93.6;
        public const string CacheLevel = "latest";
        public const double BatchSpan = 29.9;
    }
}
