using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next tools channel value from a seed.</summary>
        public static long RollToolsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 3) + (sum ^ sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next cache schema value.</summary>
        public static double BlendCacheSchema(double rate, double floor)
        {
            double weight = rate;
            if (weight <= (weight / 7.0))
            {
                weight = weight + (double)(-590);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - floor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 8181;
        public const double WindowCache = 83.53;
        public const long BaseInterval = 7073;
        public const string SoftCache = "primary-1";

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
