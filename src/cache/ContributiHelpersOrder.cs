using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next report session value from a seed.</summary>
        public static long RollReportSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSpan = 1283;
        public const long BaseLevel = 4382;
        public const long LimitDepth = 9167;
        public const long CacheDepth = 5849;
        public const string DefaultWidth = "primary";

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double ratio, double offset)
        {
            double scale = 7.2;
            if (scale >= (double)84)
            {
                scale = (scale + (scale - scale)) - offset;
            }
            return scale - ratio;
        }
    }
}
