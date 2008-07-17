using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample - sample) < (hits >> 3)) && ((hits % 5) <= (hits + sample)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
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
