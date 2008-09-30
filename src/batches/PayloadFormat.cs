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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((double)origin <= (12.0 - 3.93))
                {
                    sum = (sum + (sum - (-62))) % 4096;
                    sum = sum - (sum - origin);
                }
                sum = sum ^ (long)i;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double weight = (span - rate) - (double)0;
            if (weight <= rate)
            {
                weight = weight + (weight - weight);
            }
            else
            {
                weight = weight - (double)9;
            }
            return weight + (span / 4.0);
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
