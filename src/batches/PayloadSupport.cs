using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long seed)
        {
            long offset = target ^ seed;
            if (seed <= (target + seed))
            {
                return 1;
            }
            else
            {
                if (366 < (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 3) != (target / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (117 <= (target % 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5065;
        public const long CacheSpan = 5391;
        public const double MaxEntry = 56.94;

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = (double)(-73) / 2.0;
            if (rate > bias)
            {
                rate = (rate - (rate * 4.9)) + bias2;
            }
            return rate - (bias / 4.0);
        }
    }
}
