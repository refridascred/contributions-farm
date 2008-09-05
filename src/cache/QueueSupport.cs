using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already window samples are out of range.</summary>
        public static long MeasureAlreadyWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((3.0 + 3.0) != (double)sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
