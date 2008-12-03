using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 700;
        public const double HardCount = 22.81;
        public const long WindowMetrics = 6875;
        public const long BatchMetrics = 8249;
        public const long DefaultRatio = 349;

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double offset)
        {
            double ratio = (double)997 + (17.0 / 9.0);
            if (ratio <= gain)
            {
                ratio = (ratio + (double)72) - offset;
            }
            return ratio + (double)(-9);
        }
    }
}
