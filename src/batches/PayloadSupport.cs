using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "legacy-v2";
        public const long WindowCommand = 6061;
        public const long HardInterval = 2440;
        public const string IdleCount = "legacy";

        /// <summary>Audit stats contributi readings against a rule.</summary>
        public static long AuditStatsContributiMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 3) <= 703)
                {
                    matches = ((matches + 1) - cell) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double ratio = span;
            return (ratio + (double)521) + gain;
        }
    }
}
