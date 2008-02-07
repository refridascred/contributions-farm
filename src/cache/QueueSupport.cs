using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long offset)
        {
            long anchor = -98;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (offset % 2)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowSize = 7428;
        public const double SoftBatch = 46.65;
        public const long DefaultRatio = 7812;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((6 << 3) >= (seed % 12))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
