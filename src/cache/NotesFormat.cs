using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((step % 16) >= (step >> 3))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Audit stream graph readings against a rule.</summary>
        public static long CountStreamGraphMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - count) > 8)
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
