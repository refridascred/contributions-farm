using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Stale,
            Retry,
            Dropped,
            Pending,
        }

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
