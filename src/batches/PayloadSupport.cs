using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseCount = 64.46;
        public const long DefaultScore = 3901;
        public const long BaseProfile = 3557;

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheTimeout = 8570;
        public const long IdleSpan = 6043;
        public const string WindowSize = "fallback-edge";
        public const long RetryLayout = 1416;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3853;
        public const double MinToken = 85.71;
        public const long CacheToken = 8417;
    }
}
