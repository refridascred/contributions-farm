using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseTimeout = 40.68;
        public const double StepSpan = 1.06;
        public const long CacheEditor = 8282;
    }
}
