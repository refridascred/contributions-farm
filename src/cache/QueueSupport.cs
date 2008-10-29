using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxInterval = 23.82;
        public const long IdleEditor = 3463;
        public const long CacheFactor = 3277;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultWidth = "latest-edge";
        public const string BatchMetrics = "strict-v2";
        public const long HardMetrics = 4141;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 3939;
        public const long RetryInterval = 4658;
        public const long BatchCommits = 5021;
    }
}
