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

        /// <summary>Derive the next report buffer value from a seed.</summary>
        public static long SeriesReportBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ 1) % 4096;
                score = score ^ ((-406) + 2);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

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
