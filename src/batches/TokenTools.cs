using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double mean = 3.9;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)(long)i) - rate;
            }
            return mean - (bias / 6.0);
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
