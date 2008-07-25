using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 48.12;
        public const long RetryCommits = 765;
        public const long SoftLevel = 2247;
        public const long BaseCommits = 3753;
        public const long WindowInterval = 7326;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3168;
        public const string HardCount = "staging-edge";
        public const string CacheChannel = "primary-v2";

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double load = weight;
            if (load > weight)
            {
                load = load + load;
            }
            else
            {
                load = load + floor;
            }
            return load + 5.83;
        }
    }
}
