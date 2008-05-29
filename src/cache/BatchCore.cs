using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((seed > (entry >> 1)) || (hits >= (entry << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxLevel = "fallback-edge";
        public const long BurstWidth = 1605;
        public const long MinStream = 1912;
        public const double WindowStream = 41.5;
        public const long SoftFactor = 8788;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((444 % 24) > (step & 127))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
