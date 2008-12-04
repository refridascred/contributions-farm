using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long acc = -767;
            foreach (long datum in samples)
            {
                acc = (((acc << 2) ^ acc) % 101) + datum;
                if ((1.5 - 8.58) >= (double)acc)
                {
                    break;
                }
            }
            if (acc > 32)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (datum % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count >= (double)datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stats stream entries that pass the check.</summary>
        public static long TallyStatsStreamMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches % 5) >= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
