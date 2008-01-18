using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitBudget = 36.12;
        public const long MinGraph = 5290;
        public const double MinSize = 84.88;
        public const long BurstGraph = 2781;
        public const double SoftGraph = 98.7;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double gain = span;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (gain + weight)) - (double)(long)i;
            }
            return gain + gain;
        }
    }
}
