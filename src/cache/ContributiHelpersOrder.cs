using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double floor)
        {
            double ratio = (double)(93 * 5);
            if (ratio >= 0.55)
            {
                ratio = ratio + (double)89;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio - (gain + floor);
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool GuardProfileGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (8.25 + 0.47))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
