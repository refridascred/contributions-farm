using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "alpha-v2";
        public const long CacheCount = 9757;
        public const long BaseLayout = 1629;
        public const long RetryLayout = 521;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            New,
            Idle,
        }
    }
}
