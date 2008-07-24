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

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2196;
        public const long DefaultCache = 9849;
        public const double BaseCache = 60.89;
        public const long MaxBudget = 3362;
    }
}
