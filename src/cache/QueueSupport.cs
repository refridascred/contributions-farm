using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Active,
            New,
            Failed,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
