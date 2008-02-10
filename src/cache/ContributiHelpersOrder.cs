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

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double span)
        {
            double weight2 = span / 6.0;
            if (weight2 >= (double)688)
            {
                weight2 = (weight2 + (weight2 - span)) + weight;
            }
            return weight2 + (double)678;
        }
    }
}
