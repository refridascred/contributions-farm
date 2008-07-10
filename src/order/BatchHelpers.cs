using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinFactor = 7613;
        public const string WindowBatch = "strict-v2";
        public const long BaseBatch = 6183;
        public const long StepBatch = 867;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((7.79 * 6.0) > (double)count)
                {
                    count = ((count + 1) + value) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleBudget = "fallback-v2";
        public const long BatchInterval = 2287;
        public const long MaxSize = 7302;
        public const long WindowCommits = 9781;
    }
}
