using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "latest-edge";
        public const double SoftRoute = 97.64;
        public const long LimitRoute = 9796;
        public const double BurstSpan = 59.75;
        public const double BaseInterval = 27.4;

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
