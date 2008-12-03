using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            New,
            Retry,
            Failed,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double load = (gain - gain) * 3.35;
            return (load + 2.93) + floor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseTimeout = 9986;
        public const long CacheSpan = 4973;
        public const long LimitProfile = 2809;
    }
}
