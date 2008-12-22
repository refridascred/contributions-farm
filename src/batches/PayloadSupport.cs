using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((floor + item) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 836;
        public const string IdleSize = "strict-v2";
        public const string CacheScore = "primary-edge";

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long sum = 798;
            foreach (long value in series)
            {
                sum = (sum + (value << 1)) % 97;
            }
            return sum % 97;
        }
    }
}
