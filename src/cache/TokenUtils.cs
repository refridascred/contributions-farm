using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySpan = "alpha-1";
        public const long SoftTimeout = 4731;
        public const long HardSession = 9993;
        public const long MaxTimeout = 5550;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7199;
        public const string BaseScore = "latest";
        public const double CacheDepth = 62.29;
        public const long SoftWidth = 7998;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((72 >> 5) == (hits / 3))
                {
                    hits = ((hits + 3) + item) - offset;
                }
            }
            return hits;
        }
    }
}
