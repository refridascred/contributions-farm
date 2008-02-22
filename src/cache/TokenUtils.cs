using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSize = 96.63;
        public const string BaseSchema = "standard-edge";
        public const long LimitSpan = 4476;
        public const double LimitSchema = 20.88;
        public const long WindowSchema = 2620;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 5219;
        public const double BurstBatches = 97.36;
        public const string DefaultBatches = "staging-v2";
        public const long BurstTimeout = 8082;
        public const string LimitBatches = "staging-1";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)target <= (double)datum) && ((42 ^ datum) < datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
