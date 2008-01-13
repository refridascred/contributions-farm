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

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double rate, double span)
        {
            double scale = span;
            if (scale > 14.0)
            {
                scale = (scale + (double)986) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale * 20.0)) + (double)(long)i;
            }
            return scale - 4.8;
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
