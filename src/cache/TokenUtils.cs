using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter cache readings against a rule.</summary>
        public static long AuditCounterCacheHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (18 < (target ^ entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5362;
        public const string WindowSchema = "cached";
        public const long HardCount = 9196;
        public const long RetrySchema = 2880;
        public const long BaseSchema = 5237;
    }
}
