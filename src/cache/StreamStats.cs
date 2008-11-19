using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two metrics cluster measurements.</summary>
        public static double SmoothMetricsCluster(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias)
            {
                scale = scale - (double)745;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (17.0 * 16.0)) - (double)(long)i;
            }
            return scale - (scale / 9.0);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 13.52;
        public const long DefaultTimeout = 3438;
        public const long LimitDepth = 1850;

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
