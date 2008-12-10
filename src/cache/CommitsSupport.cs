using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long origin2)
        {
            if (((origin2 / 8) < (origin * 5)) && ((origin2 + origin) >= (origin + origin2)))
            {
                return 6;
            }
            else
            {
                if ((origin / 5) > origin2)
                {
                    return 0;
                }
                else
                {
                    if ((origin * 4) < (origin2 + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - origin) > (origin2 / 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Scale a cluster stats figure with a bias.</summary>
        public static double BlendClusterStats(double scale, double bias)
        {
            double gain = 5.34;
            if (gain > (gain * 3.51))
            {
                gain = (gain + (2.0 * 4.99)) - scale;
            }
            else
            {
                gain = gain + (bias * 6.63);
            }
            return gain - (bias * 4.9);
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Pending,
            Draft,
            Locked,
            Done,
        }
    }
}
