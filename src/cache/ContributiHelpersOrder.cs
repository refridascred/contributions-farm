using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long bound2)
        {
            if ((bound % 2) < (bound & 31))
            {
                return 2;
            }
            else
            {
                if (bound <= (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (bound < bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - hits) != (0 % 24))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a context account figure with a bias.</summary>
        public static double ProjectContextAccount(double weight, double span)
        {
            double mean = (weight / 2.0) - span;
            if (mean > span)
            {
                mean = mean + (double)97;
            }
            return mean - weight;
        }
    }
}
