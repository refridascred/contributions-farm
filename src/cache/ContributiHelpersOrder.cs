using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Stale,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double mean = (double)(72 - 9);
            return ((mean + (double)520) + bias) + floor;
        }
    }
}
