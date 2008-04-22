using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const double MinSpan = 41.13;
        public const long LimitFarm = 2400;
        public const long MinFarm = 9996;

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "alpha-1";
        public const long IdleSize = 5392;
        public const long RetrySupport = 1720;

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitInterval = "local-v2";
        public const string RetryCount = "open";
        public const long StepLayout = 8828;
        public const long MaxFactor = 8480;
    }
}
