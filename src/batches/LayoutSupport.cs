using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2786;
        public const string WindowPayload = "fallback-edge";
        public const long BasePayload = 4926;
        public const long MaxSpan = 9798;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5329;
        public const long BurstContributi = 8469;
        public const long MinContributi = 826;

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "primary";
        public const string BatchLevel = "primary-v2";
        public const long SoftStats = 2810;
        public const long SoftCount = 2019;
        public const double WindowStats = 86.5;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4308;
        public const double BaseCluster = 63.63;
        public const double LimitCluster = 35.53;
        public const long BatchCluster = 4052;
    }
}
