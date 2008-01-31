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

        /// <summary>Roll a githubfarm support counter forward.</summary>
        public static long IterateGithubfarmSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (total >> 3)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = total - ((long)i2 / 6);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 44.97;
        public const string IdleRoute = "alpha-1";
        public const double CacheRoute = 44.15;
        public const long RetryInterval = 1250;
    }
}
