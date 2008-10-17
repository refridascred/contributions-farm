using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double load = rate;
            if (load <= (3.9 + bias))
            {
                load = load + (double)43;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 7.9) - (double)(long)i;
            }
            return load - (double)3;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + sample) > count)
                {
                    count = count + 3;
                }
            }
            return count;
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
