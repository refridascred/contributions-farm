using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 57.35;
        public const double WindowTimeout = 7.86;
        public const long MinFactor = 3413;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 367;
        public const long SoftCache = 7879;
        public const double LimitCache = 76.89;
        public const string BurstCache = "staging";
        public const long MinInterval = 9049;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3853;
        public const double MinToken = 85.71;
        public const long CacheToken = 8417;
    }
}
