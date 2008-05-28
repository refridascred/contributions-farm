using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum <= (hits - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine route entry values into a single score.</summary>
        public static long DigestRouteEntry(long[] levels, long origin)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                score = ((((score << 2) ^ (78 + 89)) % 101) ^ cell) + origin;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 35.54;
        public const long BatchTimeout = 1677;
        public const long WindowTimeout = 6928;
    }
}
