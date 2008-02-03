using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((4.0 / 2.0) > (double)reading)
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next account buffer value.</summary>
        public static double SmoothAccountBuffer(double scale, double span)
        {
            double weight = scale;
            return (weight + 9.05) + span;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 15.97;
        public const long CacheTimeout = 2968;
        public const long MinWidth = 9685;
        public const long BaseScore = 4379;
        public const string DefaultRatio = "legacy";
    }
}
