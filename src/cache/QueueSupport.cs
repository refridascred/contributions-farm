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

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool ValidateCommandSchemaRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
