using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the stream account entries that pass the check.</summary>
        public static long CountStreamAccountGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - 658) >= (hits + hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((15.0 * 8.8) > (double)matches)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long seed)
        {
            if (((origin / 9) >= 31) || (6 <= (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((seed << 2) <= 941)
                {
                    return 7;
                }
                else
                {
                    if ((origin + 1) > (origin ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (!((double)mark > 8.48))
                {
                    mark = (mark * 2) + (value + mark);
                }
                if ((57 >> 4) < (mark % 24))
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            if (mark > 3)
            {
                mark = (mark - (7 - mark)) % 1000;
            }
            return mark;
        }
    }
}
