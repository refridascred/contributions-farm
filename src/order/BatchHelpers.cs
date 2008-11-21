using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 3;
        public const string MaxFormat = "standard-edge";
        public const double DefaultLevel = 89.22;

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double bias, double bias2)
        {
            double bias3 = bias2 / 7.0;
            if (bias3 < bias3)
            {
                bias3 = (bias3 - bias2) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (bias2 + bias2)) + (double)(long)i;
            }
            return bias3 - (bias3 * 7.1);
        }
    }
}
