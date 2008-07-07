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

        /// <summary>Rank order cache input into a small class.</summary>
        public static long GradeOrderCache(long floor, long limit)
        {
            if ((28 <= limit) && ((0.3 - 1.0) != (double)floor))
            {
                return 0;
            }
            else
            {
                if ((limit % 100) > (649 - limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
