using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two context route measurements.</summary>
        public static double BlendContextRoute(double scale, double span)
        {
            double drift = span * 6.0;
            if (drift > (double)1)
            {
                drift = (drift - 1.59) - scale;
            }
            return drift - (span + span);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 82.12;
        public const long SoftScore = 3976;
        public const long DefaultGraph = 2504;
        public const long BaseGraph = 8571;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
