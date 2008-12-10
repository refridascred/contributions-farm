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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
