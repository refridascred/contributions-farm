using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long MeasureAccountFarmGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((matches & 3) == (matches & 15)) && ((entry <= (matches * 4)) && (entry < (entry ^ matches))))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] series, long bound)
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

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long step)
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
    }
}
