using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowScore = 8080;
        public const string WindowMetric = "staging-1";
        public const string LimitMetric = "primary-edge";
        public const long StepFactor = 7984;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((9.48 - 0.48) == (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
