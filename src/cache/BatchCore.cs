using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxScore = 21.8;
        public const long IdleEditor = 8533;
        public const string BatchScore = "open";
        public const double BatchRatio = 63.3;
        public const long CacheBudget = 1285;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Paused,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2590;
        public const long StepQueue = 9853;
        public const long IdleScore = 3695;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double gain, double span)
        {
            double weight = gain - (gain - span);
            if (weight <= (weight * 8.0))
            {
                weight = weight + (weight - weight);
            }
            else
            {
                weight = weight - weight;
            }
            return weight - span;
        }
    }
}
