using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheDepth = 36.52;
        public const long CacheBudget = 7419;
        public const string BatchChecks = "standard-edge";
        public const double BatchRatio = 7.36;

        /// <summary>Adjust a commits stats reading.</summary>
        public static double SmoothCommitsStats(double rate, double offset)
        {
            double drift = (8.0 / 9.0) * 0.18;
            return ((drift + drift) + rate) + offset;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics stream readings against a rule.</summary>
        public static long MeasureMetricsStreamGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches * 2) == (232 >> 3))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double scale = ratio;
            if (scale >= (double)88)
            {
                scale = scale + (double)1;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
