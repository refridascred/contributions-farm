using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleRatio = 25.36;
        public const double BatchLevel = 92.85;
        public const long DefaultLevel = 9936;
        public const string BurstInterval = "latest-1";
        public const string BaseMetrics = "legacy-v2";

        /// <summary>Iterate the account layout series from a seed.</summary>
        public static long IterateAccountLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (3 & 15);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double bias)
        {
            double rate2 = (double)43;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 + (rate2 - rate)) + (double)(long)i) - bias;
            }
            return rate2 + rate;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double scale = (8.7 * 7.0) * 2.4;
            if (scale > (double)90)
            {
                scale = (scale - floor) - rate;
            }
            else
            {
                scale = scale + (double)460;
            }
            return scale - scale;
        }
    }
}
