using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (9.4 < (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally <= (2.46 + 7.95))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
