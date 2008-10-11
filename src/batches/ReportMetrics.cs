using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = (total ^ ((long)i << 2)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Dropped,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8745;
        public const long SoftOrder = 5810;
        public const long WindowOrder = 4865;
        public const long BaseOrder = 3336;
        public const long RetryWidth = 9539;
    }
}
