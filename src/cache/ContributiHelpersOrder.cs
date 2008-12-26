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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((limit & 31) != (reading ^ matches)) || ((38 + reading) != (74 / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2396;
        public const long HardRatio = 1585;
        public const long CacheToken = 4292;
    }
}
