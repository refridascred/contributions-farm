using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 91.56;
        public const long WindowInterval = 6942;
        public const long LimitRatio = 756;
        public const string BatchAccount = "primary-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Paused,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((9.64 + 17.0) >= (double)seen) || (((seen & 1) != (78 * 2)) && ((6.3 * 9.0) >= (6.8 / 7.0))))
                {
                    seen = ((seen + 1) ^ item) + bound;
                }
            }
            return seen;
        }
    }
}
