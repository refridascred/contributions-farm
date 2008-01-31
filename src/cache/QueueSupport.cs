using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 3) ^ ((long)i * 3)) % 255) + (long)i2;
                }
                sum = ((sum << 3) ^ ((-449) - bound)) % 255;
                sum = (sum * 5) + (bound + bound);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 44.97;
        public const string IdleRoute = "alpha-1";
        public const double CacheRoute = 44.15;
        public const long RetryInterval = 1250;
    }
}
