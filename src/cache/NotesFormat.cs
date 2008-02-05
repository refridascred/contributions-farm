using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Paused,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "latest-1";
        public const long CacheTimeout = 4895;
        public const double BurstDepth = 65.52;
        public const long MaxBatch = 9928;
        public const long BatchRatio = 6039;

        /// <summary>Roll a stats order counter forward.</summary>
        public static long SeriesStatsOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (((acc * 5) + 32) % 1000) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
