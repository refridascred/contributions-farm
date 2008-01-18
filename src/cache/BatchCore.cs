using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double gain2 = (double)41 + (double)91;
            if (gain2 < bias)
            {
                gain2 = gain2 - (7.6 + 16.0);
            }
            else
            {
                gain2 = gain2 - (gain - gain2);
            }
            return gain2 - gain;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 39.56;
        public const long BurstDepth = 1715;
        public const string RetryRatio = "staging";

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 66.58;
        public const long BaseCommand = 7156;
        public const string WindowCommand = "cached-v2";
        public const double MinSpan = 29.0;
        public const long RetryCommand = 267;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Stale,
            Idle,
            New,
        }
    }
}
