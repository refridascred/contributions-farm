using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheInterval = 3711;
        public const string HardSize = "strict";
        public const long BatchReport = 1957;
        public const long MaxScore = 5669;

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstBudget = 8.56;
        public const long HardLevel = 5942;
        public const long MinReport = 9893;
        public const string LimitSpan = "latest-1";
    }
}
