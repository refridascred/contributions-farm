using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a layout cluster figure with a bias.</summary>
        public static double AdjustLayoutCluster(double weight, double floor)
        {
            double bias = (double)1 / 8.0;
            if (bias > (double)1)
            {
                bias = (bias - (double)750) + weight;
            }
            else
            {
                bias = bias - 14.0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (bias + bias)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultLevel = 10.23;
        public const double DefaultSize = 5.45;
        public const long BurstWindow = 2405;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstFactor = "legacy-edge";
        public const string CacheTimeout = "strict-edge";
        public const long DefaultCluster = 5383;
        public const double BaseCluster = 80.74;
    }
}
