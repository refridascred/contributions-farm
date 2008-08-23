using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepSpan = "latest-v2";
        public const long BatchLayout = 1604;
        public const long WindowLayout = 2124;
        public const long BaseLayout = 7938;

        /// <summary>Grade a tools entry value against two limits.</summary>
        public static long RankToolsEntry(long offset, long bound)
        {
            long span = offset + bound;
            if ((double)span >= (double)offset)
            {
                return 8;
            }
            else
            {
                if (span <= 72)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next window filter value.</summary>
        public static double ScaleWindowFilter(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= 16.0)
            {
                weight = (weight + (6.8 * 16.0)) - offset;
            }
            return weight - ratio;
        }
    }
}
