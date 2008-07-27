using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 973;
        public const double IdlePayload = 11.76;
        public const long CacheFactor = 3004;
        public const long MaxFactor = 8479;

        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long CountPayloadRouteGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell / 5) <= (cell * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 35.64;
        public const long WindowReport = 1628;
        public const long RetryBudget = 6413;
        public const double BurstReport = 86.95;
        public const long CacheRatio = 5615;
    }
}
