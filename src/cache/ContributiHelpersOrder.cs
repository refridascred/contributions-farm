using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 8166;
        public const double BurstSpan = 82.43;
        public const long StepTimeout = 6694;
        public const string HardTools = "strict-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftRatio = 7929;
        public const long CacheBudget = 1872;
        public const long BatchScore = 4698;
        public const long StepStream = 6067;
        public const long LimitInterval = 8724;

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double rate2 = (double)1;
            if (rate2 >= floor)
            {
                rate2 = (rate2 + rate2) + rate;
            }
            else
            {
                rate2 = rate2 - 3.0;
            }
            return rate2 - floor;
        }
    }
}
