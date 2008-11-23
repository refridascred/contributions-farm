using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseInterval = 6144;
        public const double CacheOrder = 48.08;
        public const long IdleOrder = 3573;

        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long AuditSchemaBatchesGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((923 * 2) <= count)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 4328;
        public const long LimitSupport = 9834;
        public const string SoftSupport = "local-1";
    }
}
