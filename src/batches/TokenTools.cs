using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two payload support measurements.</summary>
        public static double ProjectPayloadSupport(double gain, double span)
        {
            double weight = (span / 7.0) - 1.03;
            return (weight - weight) + gain;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSize = 6076;
        public const double RetryWidth = 19.51;
        public const double LimitSpan = 61.32;
        public const double WindowCommits = 5.57;
        public const string IdleCommits = "primary";
    }
}
