using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double ratio, double span)
        {
            double bias = span;
            if (bias < (double)45)
            {
                bias = (bias - (bias + span)) + ratio;
            }
            return bias + 1.3;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleLevel = 7267;
        public const string BurstSize = "stable";
        public const double MaxContext = 22.23;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Pending,
            Locked,
            New,
        }
    }
}
