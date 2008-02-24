using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryLevel = 71.78;
        public const long BurstTimeout = 8692;
        public const long BurstRatio = 3459;
        public const long MinProfile = 1163;
        public const string WindowProfile = "alpha-v2";

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double weight = rate + (double)(-74);
            return (weight + weight) + offset;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Paused,
            Failed,
            Pending,
            Locked,
        }
    }
}
