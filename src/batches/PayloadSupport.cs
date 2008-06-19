using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits > (hits << 3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheBudget = "legacy";
        public const double WindowInterval = 42.3;
        public const long DefaultBudget = 2700;
        public const long IdleStream = 8480;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 791;
        public const long IdleSize = 3516;
        public const long BurstBuffer = 7119;
    }
}
