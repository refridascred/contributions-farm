using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3753;
        public const string MinSession = "strict-v2";
        public const string CacheSession = "primary";
        public const double WindowSession = 77.37;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Queued,
            New,
            Draft,
            Active,
        }

        /// <summary>Scale a tools filter figure with a bias.</summary>
        public static double ScaleToolsFilter(double ratio, double bias)
        {
            double gain = ratio;
            return gain + bias;
        }
    }
}
