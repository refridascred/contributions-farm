using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxWidth = "open-v2";
        public const double LimitDepth = 13.24;
        public const long SoftCache = 7141;
        public const long WindowFactor = 8849;
        public const string CacheInterval = "legacy-1";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Failed,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Ready,
            Queued,
            Locked,
            New,
        }
    }
}
