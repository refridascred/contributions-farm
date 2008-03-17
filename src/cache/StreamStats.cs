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

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double bias)
        {
            double ratio = (double)(946 * 5);
            if (ratio >= 7.8)
            {
                ratio = (ratio + (scale / 6.0)) + bias;
            }
            return ratio - (double)97;
        }

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
