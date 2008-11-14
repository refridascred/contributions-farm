using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double weight, double floor)
        {
            double bias = (double)(941 / 2);
            return (bias - (weight / 7.0)) + floor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "standard-edge";
        public const double MinLevel = 84.81;
        public const double BaseInterval = 56.54;
        public const long BurstSession = 1055;
        public const long SoftSession = 6675;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((seed - entry) < (matches / 9))
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
