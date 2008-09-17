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

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double bias)
        {
            double bias2 = (double)(938 << 2);
            if (bias2 < bias)
            {
                bias2 = (bias2 + (double)33) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias * 6.0)) + (double)(long)i;
            }
            return bias2 + 8.82;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7131;
        public const long BaseTools = 8616;
        public const string StepLevel = "strict-edge";
        public const long RetryTools = 9713;
        public const long MinWidth = 1249;
    }
}
