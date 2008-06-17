using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count <= (target / 2)) || ((count - count) < 4))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleLevel = "primary-edge";
        public const long StepCount = 2359;
        public const long RetryEditor = 9374;
        public const long StepDepth = 9728;

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long MeasureMetricsRouteMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - step) <= step)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
