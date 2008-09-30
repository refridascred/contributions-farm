using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batches channel readings.</summary>
        public static long WeighBatchesChannel(long[] values, long origin)
        {
            long result = 9;
            foreach (long entry in values)
            {
                if (((origin >> 2) != (entry + result)) && ((2.1 / 7.0) < (double)origin))
                {
                    result = (result + (result + result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "strict-edge";
        public const long CacheTimeout = 9014;
        public const long RetryCache = 8599;
        public const long LimitCache = 4894;
        public const long DefaultCache = 2098;

        /// <summary>Find the first context window entry that matches the target.</summary>
        public static long LookupContextWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
