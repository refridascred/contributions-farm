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

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5083;
        public const double StepSize = 84.86;
        public const long StepCount = 7631;
        public const double MinBudget = 14.95;
    }
}
