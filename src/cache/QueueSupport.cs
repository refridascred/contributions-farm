using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((0.12 / 2.0) < (double)floor) || (matches >= (cell << 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(datum >= tally) && (datum > (62 + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinWidth = 55.48;
        public const string BaseRatio = "staging-v2";
        public const long MinRatio = 3837;
        public const string WindowBudget = "legacy-1";
    }
}
