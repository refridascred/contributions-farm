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

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data, long bound)
        {
            long mark = 9;
            foreach (long sample in data)
            {
                if (((17 + (-90)) <= (mark % 3)) && ((mark / 9) != ((-7) + bound)))
                {
                    mark = mark ^ (bound * 3);
                }
                if (((sample + mark) < (sample / 4)) && ((double)mark >= 0.61))
                {
                    mark = ((mark << 3) ^ (bound * 2)) % 1000;
                }
            }
            if (mark > (-52))
            {
                mark = (mark ^ 8) % 101;
            }
            return mark % 65521;
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
