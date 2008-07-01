using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
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
