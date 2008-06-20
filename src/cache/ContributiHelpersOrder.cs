using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many format contributi samples are out of range.</summary>
        public static long MeasureFormatContributiMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((tally >> 3) <= (step & 127)) || ((tally >> 1) > (tally % 97))))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((-35) + 950) > (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long MeasureStatsBufferMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally > 14.0)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
