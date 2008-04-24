using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Idle,
            Paused,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Done,
            New,
            Queued,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "open-edge";
        public const string DefaultRecord = "open-1";
        public const long DefaultCount = 6614;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4 - item) <= (hits + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
