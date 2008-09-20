using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length > count)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepSize = 24.42;
        public const long CacheBuffer = 2852;
        public const double SoftBuffer = 27.41;
        public const string IdleInterval = "strict-v2";
        public const double DefaultBuffer = 51.49;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryCount = 91.27;
        public const long CacheMetrics = 2735;
        public const double BurstCount = 27.49;
        public const long BurstMetrics = 6960;
    }
}
