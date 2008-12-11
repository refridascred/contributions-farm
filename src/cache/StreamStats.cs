using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 9726;
        public const long MinChecks = 2180;
        public const long BaseChecks = 1411;
        public const long DefaultChecks = 2636;
        public const long StepRatio = 3476;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "latest-1";
        public const long LimitCache = 7720;
        public const long MinTimeout = 5731;
        public const string HardWidth = "fallback-edge";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((942 > reading) || ((double)seed <= (7.0 * 4.1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
