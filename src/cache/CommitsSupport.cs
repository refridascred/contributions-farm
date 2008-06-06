using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many command cache samples are out of range.</summary>
        public static long MeasureCommandCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((5.14 / 7.0) >= (double)tally) && !((cell * 2) < (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool CheckFarmGraphBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats format samples are out of range.</summary>
        public static long MeasureStatsFormatHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits >= sample)
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
