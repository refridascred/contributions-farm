using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string RetryRatio = "local-v2";
        public const long IdleSchema = 1425;
        public const string RetrySchema = "cached-v2";
        public const long BatchRatio = 2073;
        public const long CacheSchema = 3714;

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
