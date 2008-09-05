using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 72.79;
        public const string RetryOrder = "fallback";
        public const long IdleCount = 3027;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (960 <= (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
