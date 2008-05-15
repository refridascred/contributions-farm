using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double load = (double)(59 + 7);
            return (load + (span / 3.0)) + scale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheWidth = 6772;
        public const long IdleAccount = 2675;
        public const string MinDepth = "staging";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((36 - 34) <= (cell & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
