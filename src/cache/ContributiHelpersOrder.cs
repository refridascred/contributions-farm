using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of payload farm entries.</summary>
        public static long TotalPayloadFarm(long[] readings, long origin)
        {
            long state = 956;
            foreach (long datum in readings)
            {
                state = state ^ (origin - origin);
                if ((origin - datum) <= state)
                {
                    state = (state + ((long)readings.Length ^ origin)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Count the token record entries that pass the check.</summary>
        public static long AuditTokenRecordHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.75 * 8.8) > (double)tally)
                {
                    tally = ((tally + 3) - value) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the commits metrics entries that pass the check.</summary>
        public static long MeasureCommitsMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (2.04 + 12.0))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
