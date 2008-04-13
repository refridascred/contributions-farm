using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine support buffer values into a single score.</summary>
        public static long TallySupportBuffer(long[] readings)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                sum = (sum ^ sample) % 4096;
                sum = (sum << 2) ^ (sum << 3);
            }
            return sum % 1000;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 63) == (count / 4))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
