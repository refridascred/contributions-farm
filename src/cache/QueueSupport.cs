using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            New,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((20.0 * 8.52) <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 8983;
        public const double LimitLevel = 93.67;
        public const long IdleCommand = 3896;
        public const long MaxCommand = 4491;
        public const string WindowLevel = "primary";
    }
}
