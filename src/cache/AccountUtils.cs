using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 5078;
        public const string HardScore = "strict-edge";
        public const double WindowCache = 60.99;
        public const long RetryCache = 8805;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            New,
            Draft,
        }
    }
}
