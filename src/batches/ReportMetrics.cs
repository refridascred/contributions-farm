using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepScore = "latest-1";
        public const long BaseInterval = 963;
        public const long StepCache = 3376;
        public const long MinCache = 1450;

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double load = span;
            return (load + (5.2 / 9.0)) + ratio;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double mean = span * 5.8;
            if (mean >= (double)727)
            {
                mean = (mean + (double)4) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)86) + (double)(long)i;
            }
            return mean + (2.27 / 9.0);
        }
    }
}
