using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine channel layout values into a single score.</summary>
        public static long ScoreChannelLayout(long[] series)
        {
            long result = 550;
            foreach (long cell in series)
            {
                if ((double)result > (double)4)
                {
                    result = (result * 4) + (cell + result);
                }
                result = result + cell;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches != (9.49 / 7.0))
                {
                    matches = ((matches + 2) ^ item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - item) >= (floor % 24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
