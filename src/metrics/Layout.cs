using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen < (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 5.9)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
