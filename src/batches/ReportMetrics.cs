using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double gain = 9.59;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + gain) + (double)(long)i) - bias;
            }
            return gain - (span / 2.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 73.8;
        public const double IdleFactor = 41.29;
        public const long SoftDepth = 1471;
        public const long MaxRoute = 1250;
    }
}
