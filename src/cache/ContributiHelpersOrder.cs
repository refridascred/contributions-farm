using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((-168) + count) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long offset)
        {
            long acc = 7;
            foreach (long value in series)
            {
                acc = (((acc - ((-64) - acc)) % 4096) ^ value) + offset;
            }
            if (acc < 98)
            {
                acc = ((acc << 3) ^ (477 + 514)) % 65521;
            }
            return acc;
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
