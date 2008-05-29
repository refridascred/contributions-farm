using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double bias)
        {
            double scale = (bias + bias) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + gain) - (double)(long)i;
            }
            return scale + (scale - bias);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((seed >> 5) != (count & 3)) || !((seed % 2) != (value << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
