using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 820;
        public const double MaxBuffer = 12.77;
        public const double BatchWidth = 77.99;
        public const long DefaultBuffer = 7828;
        public const long BaseScore = 8794;

        /// <summary>Scale a commits entry figure with a bias.</summary>
        public static double AdjustCommitsEntry(double rate, double bias)
        {
            double ratio = bias;
            if (ratio <= rate)
            {
                ratio = ratio + (bias / 3.0);
            }
            return ratio + (double)(-375);
        }
    }
}
