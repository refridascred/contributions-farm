using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - reading) < (seen % 5))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 7784;
        public const string BaseInterval = "open-edge";
        public const long CacheTimeout = 7279;

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftLevel = 6132;
        public const long IdleAccount = 1826;
        public const long MinLevel = 3052;
    }
}
