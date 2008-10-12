using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double floor)
        {
            double weight = floor;
            if (weight > (floor + weight))
            {
                weight = weight + (weight / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (ratio / 5.0)) + (double)(long)i;
            }
            return weight - (floor / 3.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 4989;
        public const long BatchGithubfarm = 8170;
        public const string SoftGithubfarm = "primary-v2";
    }
}
