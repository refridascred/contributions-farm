using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((17.0 + 2.1) == (double)tally)
                {
                    tally = ((tally + 2) + item) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - entry) >= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long limit)
        {
            long offset = floor + limit;
            if ((13.0 - 4.76) != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset * 2) < 76)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
