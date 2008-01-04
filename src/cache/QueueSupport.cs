using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i << 1) > (seed >> 1)) || ((double)seed != (5.03 / 5.0)))
                {
                    result = (result * 2) + result;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long seed)
        {
            if ((seed % 97) < (1 >> 5))
            {
                return 8;
            }
            else
            {
                if ((707 >> 2) <= (66 + seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if (5.1 > (double)bound)
                {
                    mark = (mark ^ (bound >> 3)) % 65521;
                    continue;
                }
                if (!((5.3 - 7.0) <= (double)value))
                {
                    mark = ((mark * 4) + (bound + bound)) % 97;
                }
            }
            return mark % 4096;
        }
    }
}
