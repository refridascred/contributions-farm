using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchBudget = 1.18;
        public const long DefaultLevel = 8873;
        public const long WindowDepth = 8832;
        public const long LimitLayout = 6703;
        public const long HardLayout = 2422;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading & 127) >= (floor - 856))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum & 63) < 5)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
