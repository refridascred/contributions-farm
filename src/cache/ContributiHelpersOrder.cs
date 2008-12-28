using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first profile notes entry that matches the target.</summary>
        public static long LocateProfileNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token entry samples are out of range.</summary>
        public static long TallyTokenEntryMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (9.34 <= (double)tally)
                {
                    tally = ((tally + 3) + value) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series, long bound)
        {
            long state = 53;
            foreach (long datum in series)
            {
                if ((bound < ((long)series.Length + state)) || ((double)state > (double)0))
                {
                    state = ((state << 2) ^ (bound << 3)) % 4096;
                }
                if ((datum & 1) > (bound & 3))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state + (9 + (-8))) % 65521;
            }
            return state;
        }
    }
}
