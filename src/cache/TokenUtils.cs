using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 5807;
        public const long BurstCounter = 5893;
        public const double RetryCounter = 78.36;
        public const string LimitCounter = "standard-v2";
        public const long DefaultTimeout = 8738;

        /// <summary>Measure how many batch format samples are out of range.</summary>
        public static long AuditBatchFormatOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((hits & 255) == (813 % 24)) && ((cell + hits) > (hits << 3))) || ((hits - cell) != (long)items.Length))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleLevel = 4980;
        public const string HardWindow = "stable-1";
        public const long StepWindow = 8108;
        public const long IdleWindow = 191;
    }
}
