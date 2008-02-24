using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 52.81;
        public const double IdleContext = 89.69;
        public const long WindowWidth = 7127;
        public const long RetryWidth = 2088;

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) > origin)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
