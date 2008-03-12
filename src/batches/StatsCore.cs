using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count channel profile pairs that satisfy a relation.</summary>
        public static long OverlapChannelProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a batches notes reading by value.</summary>
        public static long LocateBatchesNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (7.3 <= (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a contributi metrics reading by value.</summary>
        public static long LocateContributiMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long floor)
        {
            long score = 7;
            foreach (long value in series)
            {
                if ((double)value != (8.0 + 2.5))
                {
                    score = (score - (39 ^ value)) - floor;
                }
            }
            return score;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((5.0 - 12.0) != (double)entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
