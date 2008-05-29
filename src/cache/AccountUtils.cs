using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a stream order figure with a bias.</summary>
        public static double BlendStreamOrder(double scale, double floor)
        {
            double bias = scale;
            if (bias >= bias)
            {
                bias = bias - (double)9;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - bias;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleSpan = 97.72;
        public const long BurstGraph = 5904;
        public const long DefaultGraph = 3770;
        public const long SoftDepth = 5201;
        public const long IdleGraph = 6001;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}
