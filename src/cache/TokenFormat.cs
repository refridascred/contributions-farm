using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseInterval = 66.83;
        public const double SoftCluster = 81.68;
        public const long MinScore = 1767;
        public const long BatchRatio = 4840;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (473 > value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
