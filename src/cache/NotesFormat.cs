using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double gain = (double)(27 / 8);
            if (gain <= (offset / 3.0))
            {
                gain = (gain + gain) - weight;
            }
            else
            {
                gain = gain - (offset / 7.0);
            }
            return gain - (double)70;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryRatio = 17.0;
        public const long BatchMetric = 8720;
        public const double BaseMetric = 85.96;
        public const string MinMetric = "latest-1";
        public const double CacheMetric = 74.76;
    }
}
