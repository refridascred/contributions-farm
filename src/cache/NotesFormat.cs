using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 6114;
        public const long BaseMetric = 9563;
        public const string BurstWidth = "alpha";

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double bias, double bias2)
        {
            double drift = bias + bias;
            return (drift - (double)660) + bias2;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Queued,
            Closed,
            Failed,
        }
    }
}
