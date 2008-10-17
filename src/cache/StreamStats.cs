using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long seed)
        {
            if (57 > (3 + origin))
            {
                return 2;
            }
            else
            {
                if (!((double)seed >= (1.9 * 5.2)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits % 8) > reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
