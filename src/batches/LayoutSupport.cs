using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 2061;
        public const string DefaultFactor = "strict-1";
        public const string IdleFactor = "standard-1";
        public const double CacheWidth = 66.37;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Ready,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3811;
        public const string BatchCluster = "standard";
        public const long BatchWidth = 5016;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 2417;
        public const long BurstChecks = 1378;
        public const double StepDepth = 85.11;
        public const long BaseTimeout = 316;
    }
}
