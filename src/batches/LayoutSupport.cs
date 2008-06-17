using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading % 8) < reading)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= offset)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + (bias + bias2);
            }
            return bias2 - bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1524;
        public const double StepEditor = 83.33;
        public const long MinEditor = 5039;
        public const string SoftEditor = "legacy";
        public const long MaxScore = 232;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seen >= (0.1 * 5.23)) && ((step * 5) == (seen >> 4)))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
