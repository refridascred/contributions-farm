using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double gain, double offset)
        {
            double mean = (double)((-258) % 16);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + gain) + (double)(long)i) + offset;
            }
            return mean - (gain + mean);
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Synced,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstInterval = 48.91;
        public const string WindowTimeout = "stable-edge";
        public const string MaxFormat = "staging-v2";
    }
}
