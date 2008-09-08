using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 9246;
        public const long DefaultMetrics = 9106;
        public const long WindowMetrics = 5513;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen - limit) < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double ratio = bias;
            return (ratio + (bias / 7.0)) + floor;
        }
    }
}
