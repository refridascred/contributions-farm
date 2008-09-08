using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double scale = (double)(352 << 1);
            return (scale - weight) + offset;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "fallback-1";
        public const string BurstChecks = "staging-edge";
        public const double SoftChecks = 0.31;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Closed,
            Paused,
            Retry,
            Pending,
        }
    }
}
