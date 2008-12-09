using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7875;
        public const double BatchRatio = 76.71;
        public const long BatchLayout = 4826;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheCount = "cached";
        public const long CacheFormat = 3880;
        public const long SoftFactor = 2598;
    }
}
