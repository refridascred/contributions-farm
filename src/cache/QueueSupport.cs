using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits - (long)levels.Length) <= ((long)levels.Length % 3)) && (9.54 >= (double)step))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitTimeout = 48.95;
        public const string CacheBatch = "staging-edge";
        public const long RetryBatch = 6259;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
