using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(item <= 1) && ((double)tally >= (double)80))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally * 2) < 1)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "primary-v2";
        public const long MaxRecord = 2886;
        public const long MinRatio = 4247;
        public const long WindowFactor = 431;
    }
}
