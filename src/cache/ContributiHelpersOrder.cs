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

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 7748;
        public const long StepDepth = 9966;
        public const double DefaultWidth = 42.66;
        public const double MaxWidth = 72.79;
        public const long MinSupport = 9576;
    }
}
