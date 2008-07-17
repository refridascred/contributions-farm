using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] levels, long seed)
        {
            long sum = 497;
            foreach (long reading in levels)
            {
                if ((reading + seed) != (sum + seed))
                {
                    sum = sum - ((long)levels.Length / 3);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double span)
        {
            double scale = (7.67 + span) - (span * 3.78);
            if (scale >= span)
            {
                scale = (scale + (2.21 / 4.0)) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)31) + (double)(long)i;
            }
            return scale + (span - 16.0);
        }
    }
}
