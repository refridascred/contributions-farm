using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowFactor = 1569;
        public const double IdleInterval = 23.43;
        public const long WindowMetrics = 5537;
        public const long StepMetrics = 7308;
        public const string BurstTimeout = "strict";

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total - origin) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
