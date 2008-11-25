using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long AuditWindowFarmMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)5 >= (double)entry)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (644 >= (tally + origin))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Dropped,
            Closed,
            Active,
            New,
        }
    }
}
