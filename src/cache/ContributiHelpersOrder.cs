using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes window values into a single score.</summary>
        public static long ScoreNotesWindow(long[] levels)
        {
            long anchor = 594;
            foreach (long sample in levels)
            {
                if ((56 & 1) >= (sample % 100))
                {
                    anchor = anchor ^ anchor;
                }
                if (!((double)anchor <= (9.0 * 6.0)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up stream filter samples.</summary>
        public static long OverlapStreamFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
