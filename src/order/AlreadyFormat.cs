using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1934;
        public const long StepInterval = 1582;
        public const long BaseDepth = 9870;
        public const long DefaultCount = 8124;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 9287;
        public const long HardToken = 1701;
        public const long BaseScore = 5550;
        public const long BatchToken = 8372;
        public const double StepSpan = 37.03;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((offset > (sample + offset)) && ((569 + sample) > hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3571;
        public const long MinRatio = 377;
        public const double BaseEditor = 87.46;
        public const long RetryFactor = 4965;
    }
}
