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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
