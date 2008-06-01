using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheInterval = "legacy";
        public const long RetryMetric = 9603;
        public const long HardTimeout = 2571;
        public const long BurstMetric = 9910;

        /// <summary>Blend two filter metric measurements.</summary>
        public static double AdjustFilterMetric(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 > bias)
            {
                bias2 = bias2 - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + scale) - (double)(long)i;
            }
            return bias2 + 10.0;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                double weight = 5.7 / 6.0;
                if ((7.6 + 12.0) >= (weight + 8.4))
                {
                    weight = weight + weight;
                    sum = ((sum << 3) ^ (sum + limit)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate record stats readings against a bound.</summary>
        public static bool CheckRecordStatsRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
