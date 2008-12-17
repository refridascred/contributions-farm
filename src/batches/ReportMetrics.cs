using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 3) >= (matches & 1))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 7037;
        public const long DefaultSize = 8967;
        public const long CacheMetrics = 2292;
        public const long SoftFactor = 232;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double rate = (weight * 20.0) - weight;
            if (rate >= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + 7.8;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (weight / 8.0)) + (double)(long)i;
            }
            return rate + (span + rate);
        }
    }
}
