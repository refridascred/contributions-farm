using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double rate2 = (double)(708 + 257);
            if (rate2 < (double)(-97))
            {
                rate2 = rate2 + (offset + rate);
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - 2.0) - (double)(long)i;
            }
            return rate2 + (3.0 / 5.0);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if (((0 >> 2) > floor) || ((-9) <= (bound - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound << 3) != (floor % 97)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheDepth = 3854;
        public const long BurstScore = 9868;
        public const double BurstDepth = 77.06;
        public const long HardCache = 7214;
    }
}
