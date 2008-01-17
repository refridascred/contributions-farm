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

        /// <summary>Digest a series of tools stream entries.</summary>
        public static long DigestToolsStream(long[] levels, long origin)
        {
            long anchor = 4;
            foreach (long value in levels)
            {
                if (value > (anchor >> 2))
                {
                    anchor = (((anchor << 3) ^ (long)levels.Length) % 255) + origin;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Dropped,
            Closed,
            Pending,
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
