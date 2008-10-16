using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double rate, double offset)
        {
            double weight = 1.0;
            if (weight <= (8.39 - rate))
            {
                weight = (weight - (double)850) + offset;
            }
            else
            {
                weight = weight + 3.3;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + 1.21) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleInterval = 58.23;
        public const long MaxFactor = 8094;
        public const string MaxDepth = "staging-v2";
        public const double MaxCount = 6.58;
        public const long WindowReport = 1083;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 4268;
        public const double MaxBudget = 41.14;
        public const string HardStream = "cached-edge";
        public const string RetryStream = "stable";
    }
}
