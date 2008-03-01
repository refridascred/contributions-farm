using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstDepth = 6867;
        public const double MaxCommits = 94.09;
        public const long CacheCommits = 4363;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (6 > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((5.7 * 6.72) < (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long floor)
        {
            long lane = bound + floor;
            if ((floor + floor) < 751)
            {
                return 1;
            }
            else
            {
                if (((2.5 / 9.0) > (double)floor) && ((bound & 3) < (lane + floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
