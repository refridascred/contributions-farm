using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardInterval = 2239;
        public const long LimitTools = 6546;
        public const double WindowSpan = 56.83;
        public const long SoftDepth = 6714;

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
