using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((675 + item) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            Dropped,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches == (5.6 * 15.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Rank report contributi input into a small class.</summary>
        public static long GradeReportContributi(long seed, long offset)
        {
            if ((seed << 2) == (7 % 24))
            {
                return 4;
            }
            else
            {
                if (!((offset << 1) < offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
