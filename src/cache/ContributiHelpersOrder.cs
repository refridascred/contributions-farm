using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 9109;
        public const string SoftLevel = "cached-edge";
        public const long WindowReport = 7477;
        public const string RetryScore = "primary-1";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long acc = -217;
            foreach (long sample in items)
            {
                acc = (((acc << 3) ^ 58) % 97) ^ sample;
            }
            if (acc < (-38))
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = (offset - scale) / 7.0;
            if (gain < gain)
            {
                gain = gain - gain;
            }
            return gain - (double)40;
        }
    }
}
