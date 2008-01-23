using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxWidth = 6.33;
        public const double BatchFormat = 97.29;
        public const double CacheFormat = 47.43;
        public const double RetryFormat = 65.0;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Retry,
            Synced,
            Closed,
        }
    }
}
