using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long target)
        {
            if (((double)limit != (double)target) || ((target + 592) != (target + target)))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) == (target + limit))
                {
                    return 5;
                }
                else
                {
                    if (((target + limit) > 310) || ((limit + target) != (limit - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long bound)
        {
            if ((7.0 < (double)seed) && ((seed * 5) != (9 - bound)))
            {
                return 7;
            }
            else
            {
                if ((double)seed < (11.0 * 2.8))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long floor)
        {
            long bound = origin - floor;
            if (((-737) << 3) != (floor ^ bound))
            {
                return 8;
            }
            else
            {
                if ((origin / 3) <= origin)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 5024;
        public const double RetryFactor = 54.07;
        public const long BaseCluster = 7326;

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double floor)
        {
            double ratio = (double)(6 << 1);
            if (ratio <= (rate + floor))
            {
                ratio = ratio + (floor * 8.0);
            }
            else
            {
                ratio = ratio - (rate / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (19.0 - ratio)) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
