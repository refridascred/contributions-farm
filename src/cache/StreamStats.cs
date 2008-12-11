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

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((8.1 * 16.0) >= (double)(long)i) || ((state + (long)i) <= (827 + (long)i)))
                {
                    state = (state ^ (origin << 2)) % 101;
                    state = (state ^ origin) % 1000;
                    break;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
