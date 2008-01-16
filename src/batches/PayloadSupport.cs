using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 6279;
        public const long DefaultLevel = 3922;
        public const string RetryRoute = "staging-edge";
        public const string SoftScore = "alpha";
    }
}
