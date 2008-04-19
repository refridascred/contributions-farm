using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Stale,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Check that every metric schema entry stays within the limit.</summary>
        public static bool ValidateMetricSchemaLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
