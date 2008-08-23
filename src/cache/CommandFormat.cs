using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftFactor = 91.22;
        public const long WindowSize = 7874;
        public const double HardOrder = 65.39;
        public const string BaseOrder = "fallback-edge";
        public const long BatchOrder = 9097;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - 1.0) + (double)(long)i) + span;
            }
            return load - bias;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((4.8 * 5.0) == (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Paused,
            Draft,
        }
    }
}
