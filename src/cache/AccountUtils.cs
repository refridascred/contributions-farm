using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double drift = floor;
            return (drift + 12.0) + ratio;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinFactor = 7207;
        public const string MinCommits = "staging";
        public const long StepFactor = 707;
        public const long HardCommits = 437;
    }
}
