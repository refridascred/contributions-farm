using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double bias)
        {
            double gain = weight;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias / 6.0)) + (double)(long)i;
            }
            return gain + 2.8;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Dropped,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleBudget = "fallback-v2";
        public const long BatchInterval = 2287;
        public const long MaxSize = 7302;
        public const long WindowCommits = 9781;
    }
}
