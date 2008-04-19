using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long floor)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                state = ((state + state) % 101) ^ entry;
                if ((15 * 5) == (floor & 7))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally ^ bound) < (long)items.Length))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftRatio = 2392;
        public const string BurstStream = "latest-1";
        public const string MinStream = "fallback-1";
        public const long BurstLevel = 7898;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - sample) < (sample * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
