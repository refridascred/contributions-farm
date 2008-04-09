using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) != (datum & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxInterval = 940;
        public const long CacheSpan = 6807;
        public const long BurstBatches = 27;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Closed,
            Draft,
            Ready,
        }
    }
}
