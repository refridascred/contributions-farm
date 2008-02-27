using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2938;
        public const long RetryScore = 2837;
        public const long BatchInterval = 2403;
        public const double BatchTools = 5.68;
        public const long CacheBudget = 4451;
    }
}
