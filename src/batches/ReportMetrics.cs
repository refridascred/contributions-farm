using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 20.53;
        public const long MinBatch = 2517;
        public const long BurstLevel = 5000;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits <= (hits - hits)) || ((cell <= hits) && ((step - 28) >= (hits * 5))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double rate = 3.0;
            if (rate > span)
            {
                rate = rate + (rate * 9.7);
            }
            return rate - scale;
        }
    }
}
