using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 3700;
        public const double SoftLevel = 82.57;
        public const string BurstTimeout = "fallback-edge";
        public const long StepCache = 3525;

        /// <summary>Validate stream channel readings against a bound.</summary>
        public static bool GuardStreamChannelLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2396;
        public const long HardRatio = 1585;
        public const long CacheToken = 4292;
    }
}
