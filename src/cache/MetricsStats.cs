using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long mark = 78;
            foreach (long cell in values)
            {
                if ((cell >= (cell >> 3)) && ((cell % 5) > (cell + cell)))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1080;
        public const long DefaultBuffer = 5393;
        public const double WindowBuffer = 80.15;
        public const long LimitSize = 5384;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Retry,
            Ready,
            Draft,
            Done,
        }
    }
}
