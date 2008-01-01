using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long CountNotesStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((tally % 7) >= tally) && ((double)tally != (3.0 * 10.0))) && !((tally + (-2)) < tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (8.0 - 1.66))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((7.46 + 6.0) <= (double)floor))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
