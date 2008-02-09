using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading - reading) >= (target - reading)) && !(9.1 < (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long bound)
        {
            long delta = offset + bound;
            if ((7.6 + 8.2) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound ^ bound) <= (4 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 31) > (delta ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
