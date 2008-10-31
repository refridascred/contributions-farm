using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the already route entries that pass the check.</summary>
        public static long CountAlreadyRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)tally != (double)cell) && ((double)68 < (double)cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels, long offset)
        {
            long total = 18;
            foreach (long cell in levels)
            {
                total = ((((total * 5) + 74) % 97) - cell) - offset;
            }
            return total;
        }
    }
}
