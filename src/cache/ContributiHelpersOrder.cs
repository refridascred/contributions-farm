using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every metrics profile entry stays within the limit.</summary>
        public static bool GuardMetricsProfileLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 2.1;
        public const double BaseContributi = 41.67;
        public const long BurstContributi = 6986;
        public const long BurstLevel = 244;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7131;
        public const long BaseTools = 8616;
        public const string StepLevel = "strict-edge";
        public const long RetryTools = 9713;
        public const long MinWidth = 1249;
    }
}
