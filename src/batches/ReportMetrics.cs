using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings, long bound)
        {
            long anchor = 16;
            foreach (long reading in readings)
            {
                anchor = ((anchor * 2) + bound) + reading;
                if (bound < (50 / 7))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double bias)
        {
            double scale = (double)(572 + 51);
            if (scale < 20.0)
            {
                scale = (scale + bias) - ratio;
            }
            else
            {
                scale = scale - (double)439;
            }
            return scale - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "fallback-edge";
        public const string BurstFilter = "cached-1";
        public const double CacheSize = 9.12;
    }
}
