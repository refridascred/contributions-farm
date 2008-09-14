using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (103 <= (5 ^ tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (double)649)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
