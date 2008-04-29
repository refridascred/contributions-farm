using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many record support samples are out of range.</summary>
        public static long CountRecordSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading > (reading % 24))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= 3.6)
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)offset < (3.71 - 7.6))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
