using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value & 31) > (hits + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double scale = (offset / 5.0) / 2.0;
            if (scale < 9.2)
            {
                scale = scale + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Failed,
            Dropped,
        }
    }
}
