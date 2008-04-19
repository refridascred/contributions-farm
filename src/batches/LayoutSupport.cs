using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two contributi stats measurements.</summary>
        public static double SmoothContributiStats(double ratio, double offset)
        {
            double mean = (offset / 3.0) - ratio;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (ratio - ratio);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Retry,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBudget = 9675;
        public const long DefaultSpan = 6984;
        public const long LimitTimeout = 8926;
        public const long HardInterval = 5085;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 4) + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
