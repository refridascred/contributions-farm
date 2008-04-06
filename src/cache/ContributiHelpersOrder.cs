using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxCount = "cached";
        public const double BaseInterval = 30.39;
        public const double IdleRecord = 36.34;
        public const double CacheInterval = 41.11;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + entry) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
