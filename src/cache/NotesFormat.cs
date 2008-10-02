using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((5 ^ value) > ((long)series.Length + value)) && (value <= (offset % 64)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Stale,
            New,
            Queued,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Stale,
            Draft,
            Idle,
        }
    }
}
