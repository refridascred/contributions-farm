using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 4671;
        public const long BurstTimeout = 8393;
        public const long HardSpan = 987;

        /// <summary>Audit filter metric readings against a rule.</summary>
        public static long MeasureFilterMetricMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) < seed)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long seed2)
        {
            if ((3.71 * 5.56) < (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((seed + 19) == (seed / 2)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
