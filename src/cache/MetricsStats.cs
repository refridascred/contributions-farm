using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((589 % 24) >= (datum + seed)) || (((double)count > (double)seed) && ((count + datum) == (seed / 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a entry stream reading by value.</summary>
        public static long LocateEntryStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels)
        {
            long state = 218;
            foreach (long value in levels)
            {
                if ((state ^ state) <= (43 + value))
                {
                    state = (state - (value + state)) % 97;
                }
            }
            if (state > (-5))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Classify a stats layout pair into a bucket.</summary>
        public static long RankStatsLayout(long offset, long seed)
        {
            long step = offset - seed;
            if (!(896 < (seed - step)))
            {
                return 4;
            }
            else
            {
                if (seed < (93 - offset))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long MeasureBufferMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((1.0 - 1.1) > (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
