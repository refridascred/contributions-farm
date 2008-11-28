using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen & 7) > (floor - seen))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Blend two cluster tools measurements.</summary>
        public static double ProjectClusterTools(double ratio, double offset)
        {
            double scale = ratio - ratio;
            if (scale > (1.5 - scale))
            {
                scale = scale - (3.86 * 5.2);
            }
            else
            {
                scale = scale - (double)46;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (ratio - offset)) - (double)(long)i;
            }
            return scale - offset;
        }
    }
}
