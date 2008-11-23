using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleSpan = 11.71;
        public const string StepGithubfarm = "fallback-1";
        public const long CacheInterval = 9635;
        public const long HardSpan = 7701;
        public const long RetryGithubfarm = 3544;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double weight = (double)815 * 10.0;
            if (weight <= (double)6)
            {
                weight = (weight - (8.7 / 5.0)) + floor;
            }
            else
            {
                weight = weight + (7.52 / 2.0);
            }
            return weight + (gain / 4.0);
        }
    }
}
