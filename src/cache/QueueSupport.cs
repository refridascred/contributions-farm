using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseScore = 70.74;
        public const string CacheCount = "strict-v2";
        public const long BurstEntry = 5601;
        public const long MaxCount = 5889;

        /// <summary>Blend two account commits measurements.</summary>
        public static double BlendAccountCommits(double gain, double floor)
        {
            double bias = gain - floor;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias + (double)8;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long seed)
        {
            long total = 14;
            foreach (long reading in readings)
            {
                total = (((total ^ (620 % 7)) % 1000) + reading) + seed;
                if ((6.25 * 9.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
