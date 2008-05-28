using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long offset)
        {
            long score = 8;
            foreach (long entry in series)
            {
                score = ((score ^ ((long)series.Length ^ offset)) % 101) + entry;
            }
            if (score > 797)
            {
                score = ((score * 4) + (score >> 1)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 1329;
        public const string HardRecord = "standard-v2";
        public const double BurstRecord = 98.45;
        public const long WindowRecord = 2004;
        public const string CacheRecord = "open";

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
