using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinCount = 7333;
        public const string CacheSize = "cached-1";
        public const long IdleToken = 3201;
        public const string BurstSize = "strict";

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double load = bias;
            if (load <= bias)
            {
                load = load - (7.48 - floor);
            }
            else
            {
                load = load - 5.4;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (floor - 12.0)) + (double)(long)i;
            }
            return load + 8.0;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long bound)
        {
            if (target > (bound % 24))
            {
                return 6;
            }
            else
            {
                if ((target * 3) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((target >> 4) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
