using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 224;
        public const string SoftCounter = "stable-v2";
        public const long RetryTimeout = 6293;
        public const long StepDepth = 5487;
        public const double CacheRatio = 26.98;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (91 >= (sample << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstBudget = 8.56;
        public const long HardLevel = 5942;
        public const long MinReport = 9893;
        public const string LimitSpan = "latest-1";
    }
}
