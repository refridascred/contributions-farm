using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((bound + matches) != (sample * 3)) && ((matches > (9 & 7)) || (30 < (sample - (-604)))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowTimeout = 3597;
        public const double HardMetrics = 60.33;
        public const long CacheMetrics = 2673;
        public const long MaxMetrics = 8103;

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double mean = 1.0;
            if (mean <= (mean + 8.0))
            {
                mean = (mean + (mean * 2.32)) - weight;
            }
            else
            {
                mean = mean - (offset * 16.0);
            }
            return mean - offset;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardWidth = 61.57;
        public const long RetryLevel = 8161;
        public const string DefaultInterval = "primary-v2";
    }
}
