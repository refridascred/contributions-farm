using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Locked,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 2074;
        public const double RetryLevel = 10.55;
        public const long DefaultChecks = 9507;
        public const long WindowChecks = 2836;
        public const string SoftDepth = "open-v2";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double weight2 = floor;
            return (weight2 - floor) + weight;
        }
    }
}
