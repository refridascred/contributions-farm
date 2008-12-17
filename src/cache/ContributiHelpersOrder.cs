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

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            New,
            Synced,
        }

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
