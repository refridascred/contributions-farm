using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 53.14;
        public const double MaxLevel = 27.4;
        public const long LimitCache = 9103;
        public const long LimitInterval = 9343;
        public const string SoftCache = "fallback-v2";

        /// <summary>Define report limits and defaults.</summary>
        public const string StepBudget = "staging-v2";
        public const string MinReport = "legacy-1";
        public const long CacheInterval = 2152;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((7.84 / 4.0) <= (double)offset)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 7632;
        public const double WindowCommand = 63.48;
        public const string SoftCount = "open-v2";
    }
}
