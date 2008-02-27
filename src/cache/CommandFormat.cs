using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Synced,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double gain, double floor)
        {
            double scale = gain;
            if (scale > 9.3)
            {
                scale = scale - (floor + 7.0);
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - (scale + floor);
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Paused,
            Stale,
        }
    }
}
