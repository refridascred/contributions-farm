using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long seed2)
        {
            if ((seed2 - seed) >= seed)
            {
                return 5;
            }
            else
            {
                if ((seed2 >> 5) == (seed2 ^ seed))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 + 3.76) <= 2.9)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftBudget = 1508;
        public const double HardFarm = 98.38;
        public const long WindowRatio = 3285;
        public const string BaseBudget = "cached-v2";

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long origin)
        {
            if ((seed ^ origin) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if ((double)origin != (6.3 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed == (3.3 - 15.0)) || ((seed & 3) == (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-9) / 8) > (seed / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
