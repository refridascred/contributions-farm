using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstTimeout = 56.66;
        public const long StepWindow = 6191;
        public const long DefaultWindow = 1256;
        public const long BurstRatio = 8058;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            New,
            Failed,
            Pending,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double bias)
        {
            double ratio = (bias + gain) * 2.76;
            return ratio + (8.28 * 6.66);
        }
    }
}
