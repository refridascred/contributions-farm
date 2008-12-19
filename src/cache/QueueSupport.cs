using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double drift = 17.0 * 16.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)(long)i) - ratio;
            }
            return drift - floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 53.14;
        public const long BatchToken = 7725;
        public const double CacheToken = 72.02;

        /// <summary>Locate a session payload reading by value.</summary>
        public static long FindSessionPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
