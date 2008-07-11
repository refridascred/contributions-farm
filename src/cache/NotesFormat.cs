using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitDepth = 6888;
        public const long MinRecord = 5968;
        public const long IdleLevel = 2911;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
