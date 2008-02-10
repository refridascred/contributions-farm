using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) >= limit)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 62.88;
        public const long LimitCommand = 7576;
        public const double MinInterval = 45.01;
    }
}
