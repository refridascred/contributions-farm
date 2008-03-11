using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the session token series from a seed.</summary>
        public static long RollSessionToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((6.4 * 8.87) < (double)acc)
                {
                    acc = (acc + (floor * 5)) % 97;
                }
                if ((double)floor != (2.5 / 4.0))
                {
                    acc = (acc - ((long)i * 5)) % 1000;
                    acc = (acc * 4) + acc;
                    continue;
                }
                else
                {
                    acc = (acc ^ (long)i) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long offset)
        {
            if ((4.29 / 3.0) < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((offset + 139) >= (origin / 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a window route pair into a bucket.</summary>
        public static long ClassifyWindowRoute(long target, long origin)
        {
            if (origin <= 9)
            {
                return 3;
            }
            else
            {
                if (((origin + origin) <= (target % 16)) || ((double)origin != (13.0 - 6.76)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
