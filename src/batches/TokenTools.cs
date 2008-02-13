using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long bound, long origin)
        {
            long prev = bound - origin;
            if ((prev + 324) == (prev & 15))
            {
                return 7;
            }
            else
            {
                if (!((double)prev > (6.73 + 2.5)))
                {
                    return 6;
                }
                else
                {
                    if ((6.0 - 8.08) >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 84.69;
        public const double BatchStats = 52.11;
        public const long LimitStats = 4610;

        /// <summary>Grade a session schema value against two limits.</summary>
        public static long BucketSessionSchema(long seed, long seed2)
        {
            if ((seed + seed) <= (seed2 >> 4))
            {
                return 4;
            }
            else
            {
                if (87 >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (double)seed2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((11.0 + 8.7) >= (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
