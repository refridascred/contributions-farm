using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double ratio, double bias)
        {
            double ratio2 = (double)(95 - (-1));
            if (ratio2 <= (double)38)
            {
                ratio2 = ((ratio2 + ratio2) - ratio) + bias;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 - 16.0);
            }
            return ratio2 + (double)52;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 4937;
        public const long CacheRatio = 4651;
        public const string BurstGithubfarm = "staging-edge";
        public const double IdleGithubfarm = 23.3;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleSize = 9082;
        public const long BatchCluster = 8824;
        public const long StepCluster = 6881;
        public const long LimitRatio = 191;
        public const string HardCluster = "fallback-edge";
    }
}
