using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftLevel = "legacy-edge";
        public const long SoftWidth = 8079;
        public const long BaseReport = 5811;
        public const string StepReport = "strict-1";

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3831;
        public const long SoftAccount = 2155;
        public const long RetryDepth = 5582;
        public const string RetryAccount = "standard-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 3285;
        public const double SoftCluster = 23.36;
        public const double MaxTimeout = 44.78;
        public const string SoftDepth = "staging-edge";
        public const double BaseCluster = 26.88;
    }
}
