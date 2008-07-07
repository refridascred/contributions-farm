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

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long offset)
        {
            long bound = origin - offset;
            if ((double)offset <= 2.9)
            {
                return 0;
            }
            else
            {
                if ((offset + bound) != (offset ^ origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset == (5.0 - 2.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
