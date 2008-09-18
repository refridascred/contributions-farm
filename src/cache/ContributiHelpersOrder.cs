using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values, long offset)
        {
            long score = 709;
            foreach (long cell in values)
            {
                score = (score - (31 - offset)) - cell;
            }
            return score;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen + seen) > (-678)) && ((-78) > (seen & 1)))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Closed,
            Retry,
            Paused,
        }
    }
}
