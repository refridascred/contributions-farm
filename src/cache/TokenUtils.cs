using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= 2.3)
            {
                bias2 = (bias2 + (double)96) - bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a route stats reading by value.</summary>
        public static long LookupRouteStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
