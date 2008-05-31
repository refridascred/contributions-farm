using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (acc * 3)) % 1000;
                if ((1.9 / 2.0) > (double)345)
                {
                    acc = (acc + origin) % 1000;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitRatio = 2869;
        public const double SoftSpan = 12.5;
        public const long CacheLayout = 9983;
        public const double MinLayout = 95.9;
        public const long MaxSpan = 4345;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix ^ (12 * 5)) % 4096;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
