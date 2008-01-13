using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series)
        {
            long total = 374;
            foreach (long cell in series)
            {
                total = total - (total + total);
                if (total > (cell - total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + hits) == (cell << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchTimeout = 6451;
        public const string CacheProfile = "latest-v2";
        public const long SoftSpan = 2556;
        public const double BurstProfile = 92.84;
        public const long CacheInterval = 4833;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Dropped,
            Failed,
            Synced,
            Pending,
        }
    }
}
